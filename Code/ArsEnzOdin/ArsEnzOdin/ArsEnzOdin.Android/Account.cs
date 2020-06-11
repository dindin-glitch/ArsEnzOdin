using Xamarin.Forms.Platform.Android;

namespace System.IO
{

    namespace ArsEnzOdin
    {

        public static class Account
        {
            public static int AccountWork(string name, int age)
            {
                string line = "Name = " + name;
                int line_number = 1;
                int line_to_edit = 1;

                using (StreamReader reader = new StreamReader(@"C:\Users\odinb\Githubs\ArsEnzOdin\Code\ArsEnzOdin\ArsEnzOdin\ArsEnzOdin.Android\Resources\AccountData.txt"))
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\odinb\Githubs\ArsEnzOdin\Code\ArsEnzOdin\ArsEnzOdin\ArsEnzOdin.Android\Resources\AccountData.txt"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line_number == line_to_edit)
                            {
                                writer.WriteLine(line);
                            }
                            else
                            {
                                writer.WriteLine("");
                            }

                            line_number++;
                        }
                    }
                }
                line = "Age = " + age;
                line_to_edit = 2;
                line_number = 1;
                using (StreamReader reader = new StreamReader(@"C:\Users\odinb\Githubs\ArsEnzOdin\Code\ArsEnzOdin\ArsEnzOdin\ArsEnzOdin.Android\Resources\AccountData.txt"))
                {
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\odinb\Githubs\ArsEnzOdin\Code\ArsEnzOdin\ArsEnzOdin\ArsEnzOdin.Android\Resources\AccountData.txt"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line_number == line_to_edit)
                            {
                                writer.WriteLine(line);
                            }

                            line_number++;
                        }
                    }
                }
                return 0;
            }
        }
    }
}