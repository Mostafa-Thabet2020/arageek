using System;
using System.Collections.Generic;
using System.Text;
using arageek.Models;
namespace arageek
{
    public class DataSeeding
    {
        
        public List<Artical> GetArticals()
        {
            User user1 = new User() { Id=1,FirstName="ahmed",LastName="adel"};

            Auther auther1 = new Auther();
            auther1.Id = 1;
            auther1.FirstName = "ahmed";
            auther1.LastName = "Salah";
            auther1.gender = Gender.male;
            auther1.CreatedDate = DateTime.Now;

            Auther auther2 = new Auther() { Id = 2, FirstName = "Mohamed", LastName = "Osama", gender = Gender.male };

            List<Auther> authers = new List<Auther>();
            authers.Add(auther1);
            authers.Add(auther2);


            Artical artical1 = new Artical() { Id = 1, auther = auther1, Title = "entity framework", Body = "adsdasddasdasdasad" };
            Artical artical2 = new Artical() { Id = 2, auther = auther2, Title = "Linq vs lambda", Body = "adsdasddasdasdasad" };

            List<Artical> articals = new List<Artical>();
            articals.Add(artical1);
            articals.Add(artical2);

            Comments comment1 = new Comments() { Id = 1, user = user1, artical = artical1, Comment = "Text" };
            Comments comment2 = new Comments() { Id = 2, user = user1, artical = artical2, Comment = "New Comment" };

            return articals;
        }
    }
}
