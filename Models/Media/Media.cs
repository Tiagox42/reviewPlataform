namespace reviewPlataform.Models.Media
{
    public abstract class Media
    {
        public Guid Id { get; set; }

        public Media()
        {
            Id = new Guid();
        }
    }
}
