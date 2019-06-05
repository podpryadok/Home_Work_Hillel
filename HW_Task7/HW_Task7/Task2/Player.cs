using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vlc.DotNet.Core;
//Создайте 2 интерфейса IPlayable и IRecodable.
//В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() 
//и void Record() / void Pause() / void Stop() соответственно. 
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.
namespace Task2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable
    {
        SoundPlayer soundPlayer;

        

        public Player(string fileAdres)
        {
            soundPlayer = new SoundPlayer(fileAdres);
        }

        void IPlayable.Play()
        {
            soundPlayer.Play();
        }

        void IPlayable.Pause()
        {
            soundPlayer.Stop();
        }

        void IPlayable.Stop()
        {
            soundPlayer.Stop();
        }

        void IRecodable.Record()
        {
            throw new NotImplementedException();
        }

        void IRecodable.Pause()
        {
            throw new NotImplementedException();
        }

        void IRecodable.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
