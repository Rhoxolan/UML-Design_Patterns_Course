namespace Printer
{
    class Printer //Context
    {
        public required PrinterState State { get; set; }

        public int PaperCount { get; set; } = 0;

        public string On()
            => State.On(this);

        public string Off()
            => State.Off(this);

        public string Print()
            => State.Print(this);

        public string RefillPaper(int paperCount)
            => State.RefillPaper(paperCount, this);
    }
}