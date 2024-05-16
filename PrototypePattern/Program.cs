using PrototypePattern.ColorRegistryExample;

Console.WriteLine("Color registry example");

// Initialize registry with standard colors.
var registry = new ColorRegistry
{
    ["red"] = new Color(255, 0, 0),
    ["green"] = new Color(0, 255, 0),
    ["blue"] = new Color(0, 0, 255)
};

registry.List();

var cloneColor = (registry["red"].Clone() as Color)!;
cloneColor.Customize(cloneColor.Red, cloneColor.Green, 33);
registry["custom"] = cloneColor;
registry.List();


_ = (registry["custom"].Clone() as Color)!;
registry.List();