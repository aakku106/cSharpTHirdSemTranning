using LibaryManagementSystem.Services;

namespace LibaryManagementSystem.Data
{
    public class BookList()
    {

        public List<Books> book = new List<Books>(){
            new Books(){
                BookId="106",
                BookName="Master",
                BookAuthor="CCN",
                BookReleaseDate="1006/jan/23",
                HowManyBooks=2
            },
            new Books(){
                BookId="8153A3FZ",
                BookName="C#",
                BookAuthor="G.S. BALUJA",
                BookReleaseDate="2016/feb/16",
                HowManyBooks=1
            },
            new Books(){
                BookId="1735",
                BookName="DSA with C",
                BookAuthor="Ram Saha",
                BookReleaseDate="2081/baisak/12",
                HowManyBooks=21
            },
            new Books(){
                BookId="2123FA",
                BookName="computer graphics",
                BookAuthor="Sha Jaha",
                BookReleaseDate="1945/sep/02",HowManyBooks=12
            },new Books(){
                BookId="ADF3",
                BookName="URRa",
                BookAuthor="CCN",
                BookReleaseDate="1232/baisak/23"
                ,
                HowManyBooks=3
            },
            new Books(){
                BookId="KS9I",
                BookName="dattebyo",
                BookAuthor="AAKKU",
                BookReleaseDate="1006/NOV/16",
                HowManyBooks=7
            },
            new Books(){
                BookId="143JAN",
                BookName="Ram Kahani",
                BookAuthor="Me",
                BookReleaseDate="11-peace"
            },new Books(){
                BookId="Gh56",
                BookName="GITA",
                BookAuthor="KRISHNA",
                BookReleaseDate=" ∞ ≠ ∞ "
            }
        };

    }

}