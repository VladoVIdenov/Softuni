namespace Problem01ClassStudent
{
    public class StudentSpecialty 
    {

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }
        
        public string SpecialtyName { get; set; }

        public int FacultyNumber { get; set; }
    }
}
