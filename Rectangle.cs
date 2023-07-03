class Rectangle
{
    private double length, width; // side1, side2
    private double area, perimeter;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double AreaCalculator()
    {

        area = length * width;

        return area;
    }

    public double PerimeterCalculator()
    {

        perimeter = 2*(length+width);

        return perimeter;
    }

    // Other methods
}
