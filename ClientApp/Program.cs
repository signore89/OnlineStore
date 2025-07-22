using ClientApp;
using OnlineStoreDouble.Models;

const string baseAddress = "https://localhost:7051/api";
const string addCategoryProduct = "ProductCategory";
const string getAllProductCategories = "ProductCategory";

var client = new HttpWorker(baseAddress);
var productCategory = new ProductCategory
{
    Id = 2,
    Name = "телефоны",
    Description = "huawei"
};

var result = await client.CategoryProducPostAsync(addCategoryProduct, productCategory);
Console.WriteLine(result);

var productCaregories = await client.GetAllCategoryProductAsync(getAllProductCategories);
foreach (var item in productCaregories)
{
    Console.WriteLine(item);
}


Console.ReadKey();
