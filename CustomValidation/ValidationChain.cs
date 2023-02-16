namespace CustomValidation
{
    public class ValidationChain<T> 
    {
        public List<Func<T, T, bool>> Rules { get; set; }
        public List<T> Conditions { get; set; }

        public ValidationChain()
        {
            Rules = new List<Func<T, T, bool>>();
            Conditions = new List<T>();
        }
    }
}
