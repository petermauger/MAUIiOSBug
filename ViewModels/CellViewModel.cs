using System;
namespace iOSCellReuseBug;

public class CellViewModel
{
    protected double rng = Random.Shared.NextDouble();
    public double HeightValue => 255 * rng;
    public virtual Color BackgroundColor => Color.FromRgb(rng, 0, 0);
}

