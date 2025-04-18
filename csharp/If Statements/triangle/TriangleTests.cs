public class TriangleTests
{
    [Fact]
    public void Equilateral_triangle_all_sides_are_equal()
    {
        Assert.True(Triangle.IsEquilateral(2, 2, 2));
    }

    [Fact]
    public void Equilateral_triangle_any_side_is_unequal()
    {
        Assert.False(Triangle.IsEquilateral(2, 3, 2));
    }

    [Fact]
    public void Equilateral_triangle_no_sides_are_equal()
    {
        Assert.False(Triangle.IsEquilateral(5, 4, 6));
    }

    [Fact]
    public void Equilateral_triangle_all_zero_sides_is_not_a_triangle()
    {
        Assert.False(Triangle.IsEquilateral(0, 0, 0));
    }

    [Fact]
    public void Equilateral_triangle_sides_may_be_floats()
    {
        Assert.True(Triangle.IsEquilateral(0.5, 0.5, 0.5));
    }

    [Fact]
    public void Isosceles_triangle_last_two_sides_are_equal()
    {
        Assert.True(Triangle.IsIsosceles(3, 4, 4));
    }

    [Fact]
    public void Isosceles_triangle_first_two_sides_are_equal()
    {
        Assert.True(Triangle.IsIsosceles(4, 4, 3));
    }

    [Fact]
    public void Isosceles_triangle_first_and_last_sides_are_equal()
    {
        Assert.True(Triangle.IsIsosceles(4, 3, 4));
    }

    [Fact]
    public void Isosceles_triangle_equilateral_triangles_are_also_isosceles()
    {
        Assert.True(Triangle.IsIsosceles(4, 4, 4));
    }

    [Fact]
    public void Isosceles_triangle_no_sides_are_equal()
    {
        Assert.False(Triangle.IsIsosceles(2, 3, 4));
    }

    [Fact]
    public void Isosceles_triangle_first_triangle_inequality_violation()
    {
        Assert.False(Triangle.IsIsosceles(1, 1, 3));
    }

    [Fact]
    public void Isosceles_triangle_second_triangle_inequality_violation()
    {
        Assert.False(Triangle.IsIsosceles(1, 3, 1));
    }

    [Fact]
    public void Isosceles_triangle_third_triangle_inequality_violation()
    {
        Assert.False(Triangle.IsIsosceles(3, 1, 1));
    }

    [Fact]
    public void Isosceles_triangle_sides_may_be_floats()
    {
        Assert.True(Triangle.IsIsosceles(0.5, 0.4, 0.5));
    }

    [Fact]
    public void Scalene_triangle_no_sides_are_equal()
    {
        Assert.True(Triangle.IsScalene(5, 4, 6));
    }

    [Fact]
    public void Scalene_triangle_all_sides_are_equal()
    {
        Assert.False(Triangle.IsScalene(4, 4, 4));
    }

    [Fact]
    public void Scalene_triangle_first_and_second_sides_are_equal()
    {
        Assert.False(Triangle.IsScalene(4, 4, 3));
    }

    [Fact]
    public void Scalene_triangle_first_and_third_sides_are_equal()
    {
        Assert.False(Triangle.IsScalene(3, 4, 3));
    }

    [Fact]
    public void Scalene_triangle_second_and_third_sides_are_equal()
    {
        Assert.False(Triangle.IsScalene(4, 3, 3));
    }

    [Fact]
    public void Scalene_triangle_may_not_violate_triangle_inequality()
    {
        Assert.False(Triangle.IsScalene(7, 3, 2));
    }

    [Fact]
    public void Scalene_triangle_sides_may_be_floats()
    {
        Assert.True(Triangle.IsScalene(0.5, 0.4, 0.6));
    }
}
