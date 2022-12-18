namespace Printer
{
    class OnPrinterState : PrinterState
    {
        public override string On(Printer printer)
            => "Принтер уже включен!";
    }
}