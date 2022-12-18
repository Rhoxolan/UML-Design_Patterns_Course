namespace Printer
{
    abstract class PrinterState //State
    {
        public virtual string Off(Printer printer)
        {
            printer.State = new OffPrinterState();
            return "Принтер выключен!";
        }

        public virtual string On(Printer printer)
        {
            if (printer.State is OffPrinterState)
            {
                printer.State = new OnPrinterState();
                return "Принтер включен!";
            }
            return "Принтер уже включен!";
        }

        public virtual string Print(Printer printer)
        {
            if(printer.PaperCount == 0)
            {
                return "Закончилась бумага!";
            }
            printer.PaperCount--;
            printer.State = new PrintPrinterState();
            return "Печатаем документ!";
        }

        public virtual string RefillPaper(int paperCount, Printer printer)
        {
            if ((printer.PaperCount + paperCount) >= 100)
            {
                return $"Слишком много бумаги! Занято {printer.PaperCount} из {100}";
            }
            printer.PaperCount += paperCount;
            printer.State = new RefillPrinterState();
            return "Пополняем бумагу!";
        }
    }
}