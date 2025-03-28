public class DartsTests
{
    [Fact]
    public void Missed_target()
    {
        Assert.Equal(0, Darts.Score(-9, 9));
    }

    [Fact]
    public void On_the_outer_circle()
    {
        Assert.Equal(1, Darts.Score(0, 10));
    }

    [Fact]
    public void On_the_middle_circle()
    {
        Assert.Equal(5, Darts.Score(-5, 0));
    }

    [Fact]
    public void On_the_inner_circle()
    {
        Assert.Equal(10, Darts.Score(0, -1));
    }

    [Fact]
    public void Exactly_on_center()
    {
        Assert.Equal(10, Darts.Score(0, 0));
    }

    [Fact]
    public void Near_the_center()
    {
        Assert.Equal(10, Darts.Score(-0.1, -0.1));
    }

    [Fact]
    public void Just_within_the_inner_circle()
    {
        Assert.Equal(10, Darts.Score(0.7, 0.7));
    }

    [Fact]
    public void Just_outside_the_inner_circle()
    {
        Assert.Equal(5, Darts.Score(0.8, -0.8));
    }

    [Fact]
    public void Just_within_the_middle_circle()
    {
        Assert.Equal(5, Darts.Score(-3.5, 3.5));
    }

    [Fact]
    public void Just_outside_the_middle_circle()
    {
        Assert.Equal(1, Darts.Score(-3.6, -3.6));
    }

    [Fact]
    public void Just_within_the_outer_circle()
    {
        Assert.Equal(1, Darts.Score(-7.0, 7.0));
    }

    [Fact]
    public void Just_outside_the_outer_circle()
    {
        Assert.Equal(0, Darts.Score(7.1, -7.1));
    }

    [Fact]
    public void Asymmetric_position_between_the_inner_and_middle_circles()
    {
        Assert.Equal(5, Darts.Score(0.5, -4));
    }
}
