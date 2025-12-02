// ReSharper disable UnusedType.Global
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
namespace RSRD253;

#nullable enable

class Order
{
    private List<Item>? _items;

    public List<Item> Items
    {
        get => _items ??= [];
        set => _items = value;
    }
}

class Item;
