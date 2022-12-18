namespace Printer
{
    class RefillPrinterState : PrinterState
    {
        public override string RefillPaper(int paperCount, Printer printer)
            => "Мы уже пополняем бумагу!";
    }
}