using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontRepeatYourself1
{
    public class ArticleService
    {
        public void Edit(Article article, User user)
        {
            if (!user.IsInRole("Editors") && user.Id != article.Author.Id)
            {
                // throw exception
            }
            // do other work
        }

        public void Publish(Article article, User user)
        {
            if (!user.IsInRole("Editors") && user.Id != article.Author.Id)
            {
                // throw exception
            }
            // do other work
        }

        public void Delete(Article article, User user)
        {
            if (!user.IsInRole("Editors") && user.Id != article.Author.Id)
            {
                // throw exception
            }
            // do other work
        }
    }
}
