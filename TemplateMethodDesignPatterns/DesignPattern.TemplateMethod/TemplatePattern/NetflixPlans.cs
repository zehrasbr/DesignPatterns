namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public abstract class NetflixPlans
    {
        public abstract string PlanType  { get; set; }
        public abstract int CountPerson  { get; set; }
        public abstract decimal Price  { get; set; }
        public abstract string Resolution  { get; set; }
        public abstract string Content  { get; set; }
    }
}
