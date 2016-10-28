namespace FacadeExample.Contracts
{
    using Models;

    public interface IPlayer
    {
        void Play();

        void Stop();

        void Load(MediaEntity media);
    }
}
