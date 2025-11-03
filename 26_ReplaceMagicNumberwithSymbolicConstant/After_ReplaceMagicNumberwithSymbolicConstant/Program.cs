public class Physics
{
    // Khai báo hằng số trọng lực
    private const double GRAVITATIONAL_CONSTANT = 9.81;

    // Tính thế năng: Ep = m * h * g
    public double PotentialEnergy(double mass, double height)
    {
        return mass * height * GRAVITATIONAL_CONSTANT;
    }
}
