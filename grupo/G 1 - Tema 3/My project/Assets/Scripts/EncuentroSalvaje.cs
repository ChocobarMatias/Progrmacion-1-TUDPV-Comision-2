using System;

public class EncuentroSalvaje
{
    private readonly Random _random = new Random();
    public float Probabilidad { get; }

    public EncuentroSalvaje(float probabilidad = 0.05f)
    {
        Probabilidad = probabilidad;
    }

    public bool IntentarEncuentro()
    {
        return _random.NextDouble() < Probabilidad;
    }
}
