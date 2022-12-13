using static System.Console;

namespace Resumes
{
    internal class Program
    {
        static void Main()
        {
            Resume resume1 = Resume.CreateBuilder()
                .SetFullName("Petrov Vasily Anatolievich")
                .SetAge("53")
                .SetPhoneNumber("+380XXXXXXXXX")
                .SetEMail("Example@example.com")
                .SetEducation("UPT").Build();

            WriteLine(resume1.FullName);
            WriteLine(resume1.Age);
            WriteLine(resume1.PhoneNumber);
            WriteLine(resume1.EMail);
            if (!String.IsNullOrEmpty(resume1.Education))
            {
                WriteLine(resume1.Education);
            }
            if (!String.IsNullOrEmpty(resume1.WorkExperience))
            {
                WriteLine(resume1.WorkExperience);
            }
            if (!String.IsNullOrEmpty(resume1.Skills))
            {
                WriteLine(resume1.Skills);
            }

            //Example with runtime error - charm field not initialized
            //Resume resume2 = Resume.CreateBuilder()
            //    .SetFullName("Petrov Vasily Anatolievich")
            //    .SetPhoneNumber("+380XXXXXXXXX")
            //    .SetEMail("Example@example.com")
            //    .SetEducation("UPT").Build();
        }
    }

    class Resume
    {
        public string FullName { get; set; } = String.Empty;

        public int Age { get; set; } = 0;

        public string PhoneNumber { get; set; } = String.Empty;

        public string EMail { get; set; } = String.Empty;

        public string? Education { get; set; } = null;

        public string? WorkExperience { get; set; } = null;

        public string? Skills { get; set; } = null;

        public static ResumeBuilder CreateBuilder()
        {
            return new ResumeBuilder();
        }
    }

    class ResumeBuilder
    {
        private Resume resume;

        public ResumeBuilder()
        {
            resume = new();
        }

        public ResumeBuilder SetFullName(string fullName)
        {
            resume.FullName = fullName;
            return this;
        }

        public ResumeBuilder SetAge(string age)
        {
            resume.Age = Convert.ToInt32(age);
            return this;
        }

        public ResumeBuilder SetPhoneNumber(string phoneNumber)
        {
            resume.PhoneNumber = phoneNumber;
            return this;
        }

        public ResumeBuilder SetEMail(string eMail)
        {
            resume.EMail = eMail;
            return this;
        }

        public ResumeBuilder SetEducation(string education)
        {
            resume.Education = education;
            return this;
        }

        public ResumeBuilder SetWorkExperience(string workExperience)
        {
            resume.WorkExperience = workExperience;
            return this;
        }

        public ResumeBuilder SetWorkSkills(string skills)
        {
            resume.Skills = skills;
            return this;
        }

        public Resume Build()
        {
            if(String.IsNullOrEmpty(resume.FullName) ||
                String.IsNullOrEmpty(resume.PhoneNumber) ||
                String.IsNullOrEmpty(resume.EMail) ||
                resume.Age == 0)
            {
                throw new Exception("Build exception");
            }
            return resume;
        }

        //public static implicit operator Resume(ResumeBuilder builder)
        //{
        //    return builder.resume;
        //}

    }
}