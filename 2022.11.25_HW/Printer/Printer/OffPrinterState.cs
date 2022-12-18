namespace Printer
{
    class OffPrinterState : PrinterState
    {
        public override string Off(Printer printer)
            => "Принтер уже выключен!";

        public override string Print(Printer printer)
            => "Принтер выключен! Сначала включите его.";

        public override string RefillPaper(int paperCount, Printer printer)
            => "Принтер выключен! Сначала включите его.";
    }
}