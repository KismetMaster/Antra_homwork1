using ConsoleApp4;
//MyStack<int> intStack = new MyStack<int>();
//intStack.Push(1);
//intStack.Push(2);
//intStack.Push(3);
//Console.WriteLine($"Count: {intStack.Count()}");  // 输出: Count: 3

//Console.WriteLine($"Popped: {intStack.Pop()}");    // 输出: Popped: 3
//Console.WriteLine($"Count: {intStack.Count()}");  // 输出: Count: 2

//// 示例：使用 MyStack<string>
//MyStack<string> stringStack = new MyStack<string>();
//stringStack.Push("Hello");
//stringStack.Push("World");
//Console.WriteLine($"Count: {stringStack.Count()}");  // 输出: Count: 2

//Console.WriteLine($"Popped: {stringStack.Pop()}");   // 输出: Popped: World
//Console.WriteLine($"Count: {stringStack.Count()}");  // 输出: Count: 1
public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        _items.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        _items.Remove(item);
    }

    public void Save()
    {
        // 实现数据源的保存逻辑（例如，保存到数据库）
        // 在此示例中，我们将模拟一个保存操作。
        Console.WriteLine("数据已保存！");
    }

    public IEnumerable<T> GetAll()
    {
        return _items.AsReadOnly();
    }

    public T GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        IRepository<Product> productRepository = new GenericRepository<Product>();

        // 添加新产品
        var product1 = new Product { Id = 1, Name = "产品 1" };
        productRepository.Add(product1);

        // 添加另一个产品
        var product2 = new Product { Id = 2, Name = "产品 2" };
        productRepository.Add(product2);

        // 保存更改
        productRepository.Save();

        // 获取所有产品
        var allProducts = productRepository.GetAll();
        Console.WriteLine("所有产品：");
        foreach (var product in allProducts)
        {
            Console.WriteLine($"Id: {product.Id}, 名称: {product.Name}");
        }

        // 移除一个产品
        productRepository.Remove(product1);

        // 再次保存更改
        productRepository.Save();
    }
}
public class Product : Entity
{
    public string Name { get; set; }
}

public interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}

