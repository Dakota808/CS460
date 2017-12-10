# Here's the Lab 4 in a nutshell

So you start by building the the Index page which will give you access to the other pages that will be created.

@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <div>
        <h2>Homework 4</h2>
        <center>
            <p>
                MVC application on a webpage platform
            </p>
        </center>
    </div>

    <p>
        This Assignment is present and demonstrate the input and output
        that goes between html
    </p>

    <ul>
        <li>@Html.ActionLink("Page 1", "Page_1")</li>
        <li>@Html.ActionLink("Page 2", "Page_2")</li>
        <li>@Html.ActionLink("Page 3", "Page_3")</li>
    </ul>
</html>

After that you will go into your home controller and add the fucntion to call this view Which just a simple line of code where 
all you are doing is calling the View of Index.

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

This will follow the same idea for each of the parts of the lab which is the writing each of the different views and adding a line of
code to run each view.
Note: That you need to make connections between each view otherwise it will never run it will give a server error.

These next section will display all of the function of each page
this is collaborated with TJ Dennis

## Page 1

[HttpPost]
        public ActionResult Page1()
        {
            string errorMessage = "Invalid input, proceed with destruction, Skynet is the virus";
            string score_1 = Request.QueryString["score1"];
            string score_2 = Request.QueryString["score2"];
            double grade;
            ViewBag.RequestMethod = "GET";



            try
            {
                double score1 = double.Parse(score_1);
                double score2 = double.Parse(score_2);

                if (score1 > score2)
                {
                    ViewBag.Message = "Come one now who gets more than 100% these days.";
                    return View();
                }
                grade = (score1 / score2) * 100;
            }
            catch
            {
                ViewBag.Message = errorMessage;
                return View();
            }

            ViewBag.Message = Math.Round(grade, 2);
            return View();
        }

## Page 2

        [HttpPost]
        public ActionResult Page2(FormCollection form)
        {
            string day = Request.Form["day"];
            string month = Request.Form["month"];
            string year = Request.Form["year"];

            int day1 = (int.Parse(day));
            int month1 = (int.Parse(month));
            int year1 = (int.Parse(year)) % 9;

            string[] bodyPart = { "hair", "ears", "nose", "beak", "crown", "teeth", "lips", "guts", "fingers" };

            string[] bodyPart2 = { "eyes", "neck", "shoulders", "arms", "hands", "chest", "belly", "butt", "legs", "knees", "feet", "toes" };

            string[] adjective = { "hairy", "repulsive", "repugnant", "smelly", "foul", "horrid", "gigantic", "ridiculous", "misshapen", "groutesque" };

            string[] animal = { "Dragon", "Shark", "sloth", "Python", "warthog", "half witted boulder", "raccoon", "vermin" };

            string insult = "input: (" + day + "/" + month + "/" + year + ")" + " ~Your " + bodyPart[day1 % 9] + " are more " + adjective[(month1 + day1) % 10] + " and " + adjective[year1] + " than a " + animal[(day1 * year1) % 8] + "'s " + bodyPart2[(month1 * 3) % 12] + ".~";

            ViewBag.Message = insult;
            return View();
        }

## Page 3

[HttpPost]
        public ActionResult Page3(double amount, double payment, double rate, double years)
        {

            double a = 0;
            double p = amount - payment;
            double r = (rate / 12) / 100;
            double n = years * 12;

            if (p <= 0)
            {
                ViewBag.Message = "Now thats just silly";
                return View();
            }

            if (years > 0)
            {
                if (rate != 0)
                {
                    a = p * ((r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1));

                }
                else
                {
                    a = p / n;
                }

            }
            a = Math.Round(a, 2);
            String Loan = "Amount Borrowed - $" + p + ", Interest Rate - " + rate + "%, For - " + years + " Years.";
            ViewBag.Loan = Loan;
            ViewBag.MonthlyPayment = a;
            ViewBag.TotalPayment = a * n;
            return View();
        }
