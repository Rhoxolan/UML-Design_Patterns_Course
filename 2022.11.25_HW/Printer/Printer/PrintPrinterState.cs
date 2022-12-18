namespace Printer
{
    class PrintPrinterState : PrinterState
    {
        public override string Print(Printer printer)
            => "Мы уже печатаем!";
    }
}