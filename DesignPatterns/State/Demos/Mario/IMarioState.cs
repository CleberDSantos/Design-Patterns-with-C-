namespace State.Demos.Mario
{
    public interface IMarioState
    {
        IMarioState PegarCogumelo();

        IMarioState PegarFlor();

        IMarioState PegarPena();

        IMarioState LevarDano();
    }
}