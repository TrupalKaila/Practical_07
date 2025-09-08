using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
    public interface ICreateDocument
    {
        void CreateDocument(string content);
    }
    public interface IReadDocument
    {
        string ReadDocument(int id);
    }
    public interface IUpdateDocument
    {
        string UpdateDocument(int id, string content);
    }
    public interface IDeleteDocument
    {
        void DeleteDocument(int id);
    }
    public class ReadOnlyUser : IReadDocument
    {
        public string ReadDocument(int id)
        {
            return $"Random Content from DocumentId : {id}";
        }
    }
    public class AdminUser : ICreateDocument, IReadDocument, IUpdateDocument, IDeleteDocument
    {
        public void CreateDocument(string content)
        {
            Console.WriteLine($"Created document with content : {content}");
        }
        public string ReadDocument(int id)
        {
            return $"Random Content from DocumentId : {id}";
        }
        public string UpdateDocument(int id, string content)
        {
            return $"Update Document: Id: {id}, content: {content}";
        }
        public void DeleteDocument(int id)
        {
            Console.WriteLine($"Deleted document at id : {id}");
        }
    }
}
