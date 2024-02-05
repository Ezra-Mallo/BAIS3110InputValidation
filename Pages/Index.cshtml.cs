using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
System.com
namespace BAIS3110InputValidation.Pages
{
    public class IndexModel : PageModel
    {
        public string NameResponse;
        public string MessageResponse;
        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string MessageText { get; set; }
        public void OnPost()
        {
            // Name Textbox
            if (UserName != null)
            {
                string Name = UserName; // Grab the UserName from the Form
                Regex NameRegularExpression = new Regex(@"^[a-zA-Z]{3,}");
                if (NameRegularExpression.Match(Name).Success)
                    NameResponse = Name;
                else
                    NameResponse = "Name is too short";
            }



            // Name Textbox
            if (MessageText != null)
            {
                string msg = MessageText; // Grab the UserName from the Form
                Regex msgRegularExpression = new Regex(@"^<b>.*?</b>$|^<i>.*?</i>$|^<u>.*?</u>$");
                if (msgRegularExpression.Match(msg).Success)
                    MessageResponse = msg;
                else
                    MessageResponse = "Not accepted";
            }











            // MessageText Textarea
            if (MessageText != null)
                MessageResponse = MessageText;
        }







    }
}
