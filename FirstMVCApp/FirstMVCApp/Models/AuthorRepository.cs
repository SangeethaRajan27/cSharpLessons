using System.Text;

namespace FirstMVCApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int,Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists) { 
                using(StreamReader sr=new StreamReader(fName)) {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    //data is always lenght 5 if it contains empty line not do that
                    if(data.Length==5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }
                    }
                }
            }
            return list;
        }
        public static Author StringToAuthor(String[] data,Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.AuthorDateofBirth = DateTime.Parse(data[2]);
            author.NoofBooksPublished = (data[3]);
            author.Royaltycompany = (data[4]);
            return author;
        }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"c:\temp\Author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.AuthorDateofBirth},{pAuthor.NoofBooksPublished},{pAuthor.Royaltycompany}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void RemoveAuthor(int id)
        {
            String fName= @"c:\temp\Author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
                foreach(Author author in list.Values)
                {
                if (author.AuthorID != id)
                {
                    sbAuthors.Append($"{author.AuthorID},{author.AuthorName},{author.AuthorDateofBirth},"+
                        $"{author.NoofBooksPublished},{author.Royaltycompany} {Environment.NewLine}");
                }
                }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fName= @"c:\temp\Author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using(StreamWriter sw=new StreamWriter(fName))
            {
                foreach(Author author in list.Values)
                {
                    if(author.AuthorID!=pAuthor.AuthorID)
                        strAuthor=$"{author.AuthorID},{author.AuthorName},{author.AuthorDateofBirth},{author.NoofBooksPublished},{author.Royaltycompany}"; //new object
                    else
                        strAuthor= $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.AuthorDateofBirth},{pAuthor.NoofBooksPublished},{pAuthor.Royaltycompany}"; //exisiting object update
                    sw.WriteLine(strAuthor);
                }
            }
        }
    }
}
