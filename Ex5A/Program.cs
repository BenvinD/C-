using System;
using System.Text.RegularExpressions;
using System.Globalization;
class strings
{
    public string s;
    public string tmp;
    public strings(string str)
    {
        s = str;
    }
    public int lenstring()
    {
        return s.Length;
    }
    public void insstr(int pt,string st)
    {
        s = s.Insert(pt,st);
        Console.WriteLine("Instered string: "+ st);
    }
    public void rmstr(int st,int en)
    {
        s = s.Remove(st,en);
        Console.WriteLine("Removed string.");
    }
    public void repl(string st, string r)
    {
        s = s.Replace(st,r);
        Console.WriteLine("Replaced string.");
    }
    public void toup()
    {
        s = s.ToUpper();
        Console.WriteLine("Converted the string to upper.");
    }
    public void tolo()
    {
        s = s.ToLower();
        Console.WriteLine("Converted the string to lower.");
    }
    public void splstr(string st)
    {
        string[] stList = s.Split(st);  
        foreach (string i in stList)  
            Console.WriteLine(i);
    }
    public string cpystr()
    {
        tmp = String.Copy(s);
        return tmp;
    }
    public void constr(string sub)
    {
        Console.WriteLine(s.Contains(sub));
    }
    public void joinst(string st)
    {
        s+=st;
        Console.WriteLine("Joined String");
    }
    public void subst(int st)
    {
        Console.WriteLine(s.Substring(st));
    }
    public void show()
    {
        Console.WriteLine("The string now is: "+ this.s);
    }
}

class Regexs
{
    public string s;
    public Regexs(string str)
    {
        s = str;
    }
    public void tc()
    {
        Regex regularExpression = new Regex(@"\b[A-Z]+\b");
        MatchCollection matches = regularExpression.Matches(s);
        foreach (Match match in matches)
        {
            if(match.Length != 0)
                {
                    System.Console.WriteLine(match);
                } 
        } 
    }
    public void lc()
    {
        Regex regularExpression = new Regex(@"\b[a-z]*");
        MatchCollection matches = regularExpression.Matches(s);
        foreach (Match match in matches)
        {
            if(match.Length != 0)
                {
                    System.Console.WriteLine(match);
                } 
        } 
    }
    public void digits()
    {
        Regex regularExpression = new Regex(@"\d+");
        MatchCollection matches = regularExpression.Matches(s);
        foreach (Match match in matches)
        {
            if(match.Length != 0)
                {
                    System.Console.WriteLine(match);
                } 
        }
    }
    public void urlsplitter()
    {
        Regex validateDateRegex = new Regex("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
        if(validateDateRegex.IsMatch(s))
        {
           string regexPattern = @"^(?<s1>(?<s0>[^:/\?#]+):)?(?<a1>" + @"//(?<a0>[^/\?#]*))?(?<p0>[^\?#]*)" + @"(?<q1>\?(?<q0>[^#]*))?" + @"(?<f1>#(?<f0>.*))?";
           Regex re = new Regex(regexPattern, RegexOptions.ExplicitCapture); 
           Match m = re.Match(s);
           Console.WriteLine(
              m.Groups["s0"].Value + "  (Scheme without colon)"); 
           Console.WriteLine(
              m.Groups["s1"].Value + "  (Scheme with colon)"); 
           Console.WriteLine( 
              m.Groups["a0"].Value + "  (Authority without //)"); 
           Console.WriteLine(  
              m.Groups["a1"].Value + "  (Authority with //)"); 
           Console.WriteLine( 
              m.Groups["p0"].Value + "  (Path)"); 
           Console.WriteLine( 
              m.Groups["q0"].Value + "  (Query without ?)"); 
           Console.WriteLine(  
              m.Groups["q1"].Value + "  (Query with ?)"); 
           Console.WriteLine(  
              m.Groups["f0"].Value + "  (Fragment without #)"); 
           Console.WriteLine( 
              m.Groups["f1"].Value + "  (Fragment with #)"); 
        }
        else
        {
            Console.WriteLine("Invalid URL");
        }
    }
    public void validateemail()
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");  
        Match match = regex.Match(s);  
        if (match.Success)  
        Console.WriteLine(s + " is Valid Email Address");   
        else  
        Console.WriteLine(s + " is Invalid Email Address");  
    }  
    public void dob()
    {
        Regex regex = new Regex(@"(((0|1|2)[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
        bool isValid = regex.IsMatch(s);
        DateTime dt;
        isValid = DateTime.TryParseExact(s, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
        if (!isValid)
        {
            Console.WriteLine("Invalid Date.");
        }
        else
        {
            Console.WriteLine("Valid Date.");
        }
    }
    public void urk()
    {
        Regex regex = new Regex(@"^[P|U|R][R|L|P][K|P|C][0-9]{2}CS[1-7]{1}[0-3][0-9]{2}");
        //([Uu][Rr][Kk])22[a-zA-Z][a-zA-Z]\d\d\d\d$
        bool isValid = regex.IsMatch(s);
        if (!isValid)
        {
            Console.WriteLine("Invalid Reg_No.");
        }
        else
        {
            Console.WriteLine("Valid Reg_No.");
        }
    }
    public void phone()
    {
        Regex regex = new Regex(@"^([0]|\+91)?[7896]\d{9}");
        bool isValid = regex.IsMatch(s);
        if (!isValid)
        {
            Console.WriteLine("Invalid Mobile Number.");
        }
        else
        {
            Console.WriteLine("Valid Mobile Number.");
        }
    }
}
class driver
{
    public static void Main()
    {
        int mch=0;
        while(mch!=3)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1 - String Operations");
            Console.WriteLine("2 - Regex");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("Enter you Choice");
            mch = int.Parse(Console.ReadLine());
            if(mch == 1)
            {
                int sch = 0;
                do
                {
                Console.WriteLine("Enter the input string: ");
                string str = Console.ReadLine();
                strings s = new strings(str);
                Console.WriteLine("String Menu");
                Console.WriteLine("1 - Length of string");
                Console.WriteLine("2 - Insert into string");
                Console.WriteLine("3 - Remove from string");
                Console.WriteLine("4 - Replace string");
                Console.WriteLine("5 - To upper");
                Console.WriteLine("6 - To lower");
                Console.WriteLine("7 - Split string");
                Console.WriteLine("8 - Copy string");
                Console.WriteLine("9 - Contains to");
                Console.WriteLine("10 - Join");
                Console.WriteLine("11 - Sub String");
                Console.WriteLine("12 - Main Menu");
                Console.WriteLine("Enter you Choice");
                sch = int.Parse(Console.ReadLine());
                switch(sch){
                    case 1:
                    Console.WriteLine("The Length of the string is "+s.lenstring());
                    break;
                    case 2:
                    Console.WriteLine("Enter Index of the insertion positon: ");
                    int pt = int.Parse(Console.ReadLine());
                    if(pt<s.lenstring())
                    {
                        Console.WriteLine("Enter the string: ");
                        string st = Console.ReadLine();
                        s.insstr(pt,st);
                        s.show();
                    }
                    else
                    {
                        Console.WriteLine("Invalid positon: ");
                    }
                    break;
                    case 3:
                    int so,eo;
                    Console.WriteLine("Enter the starting Index: ");
                    so = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the ending Index: ");
                    eo = int.Parse(Console.ReadLine());
                    if(so <s.lenstring()&& eo <s.lenstring())
                    {
                        s.rmstr(so,eo);
                        s.show();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index");
                    }
                    break;
                    case 4:
                        Console.WriteLine("Enter the string to Replace: ");
                        string toa = Console.ReadLine();
                        Console.WriteLine("Enter the string to be Replaced: ");
                        string tob = Console.ReadLine();
                        s.repl(toa,tob);
                        s.show();
                    break;
                    case 5:
                    s.toup();
                    s.show();
                    break;
                    case 6:
                    s.tolo();
                    s.show();
                    break;
                    case 7:
                        Console.WriteLine("Enter the string with which we have to split: ");
                        string stb = Console.ReadLine();
                        s.splstr(stb);
                    break;
                    case 8:
                    string cop = s.cpystr();
                    Console.WriteLine("The Copied string is "+cop);
                    break;
                    case 9:
                    Console.WriteLine("Enter the string to be checked: ");
                        string con = Console.ReadLine();
                        s.constr(con);
                    break;
                    case 10:
                        Console.WriteLine("Enter the string to be Joined: ");
                        string jon = Console.ReadLine();
                        s.joinst(jon);
                        s.show();
                    break;
                    case 11:
                        Console.WriteLine("Enter the sub string index: ");
                        int son = int.Parse(Console.ReadLine());
                        s.subst(son);
                    break;
                }
                }while(sch!=12);
            }
            else if(mch == 2)
            {
                int rch = 0;
                do
                {
                Console.WriteLine("Regex Menu");
                Console.WriteLine("1 - Find word with Title Case");
                Console.WriteLine("2 - Find word with lower case");
                Console.WriteLine("3 - Find Digits");
                Console.WriteLine("4 - Split URL");
                Console.WriteLine("5 - Validate Email");
                Console.WriteLine("6 - Validate Date of Birth (dd/mm/yyyy)");
                Console.WriteLine("7 - Validate CS Reg_No");
                Console.WriteLine("8 - Validate Indian Mobile number");
                Console.WriteLine("9 - Main Menu");
                Console.WriteLine("Enter you Choice");
                rch = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the input string: ");
                string stre = Console.ReadLine();
                Regexs s = new Regexs(stre);
                switch(rch){
                    case 1:
                    s.tc();
                    break;
                    case 2:
                    s.lc();
                    break;
                    case 3:
                    s.digits();
                    break;
                    case 4:
                    s.urlsplitter();
                    break;
                    case 5:
                    s.validateemail();
                    break;
                    case 6:
                    s.dob();
                    break;
                    case 7:
                    s.urk();
                    break;
                    case 8:
                    s.phone();
                    break;
                }
                }while(rch!=9);
            }
            else
            {
                Console.WriteLine("Wrong Choice Enter Again");
            }
        }
    }
}