
namespace WildFarm_Ex.Foods
{
    public abstract class Food
    {
        public int Quantity { get; private set;}

        public Food(int qty)
        {
            this.Quantity = qty;
        }
    }
}
