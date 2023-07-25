namespace InterfaceSegregationPrinciple
{

    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document document);
        void Scan (Document document);
        void Fax(Document document);
       
    }

    public interface IPrinter
    {
        void Print (Document document);
    }

    public interface IScanner
    {
        void Scan (Document document);
    }

    public class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMultiFunction : IPrinter, IScanner
    {
        
    }

    public class MultiFunction :IMultiFunction
    {
        private readonly IPrinter printer;
        private readonly IScanner scanner;

        public MultiFunction(IPrinter printer, IScanner scanner)
        {
            this.printer = printer ?? throw new ArgumentNullException(nameof(printer));
            this.scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
        }

        public void Print(Document document)
        {
            printer.Print(document);
        }

        public void Scan(Document document)
        {
           scanner.Scan(document);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}