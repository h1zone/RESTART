using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousMusic : MonoBehaviour
{
    [Header("Класс воспроизведения фоновой музыки")]

    [Tooltip("Массив BG-треков")]
    public AudioClip[] backgroundMusic; 

    // Начинаем проигрывать с первого трека
    int currentMusic = 0; 

    void Start()
    {
        InitializeBackgroundMusic();
    }

    void Update()
    {
        // Если закончился трек -> начинаем проигрывать массив с первого либо берем следующий трек
        if (!GetComponent<AudioSource>().isPlaying)
        {
            currentMusic++;

            if (currentMusic >= backgroundMusic.Length) 
            {
                currentMusic = 0;
            }

            GetComponent<AudioSource>().clip = backgroundMusic[currentMusic]; 
            GetComponent<AudioSource>().Play();
        }

        // Проверка настройки пользователя выключен ли у него звук в настройках игры
        if (PlayerPrefs.GetInt("AudioOFF") == 0)
        {
            GetComponent<AudioSource>().mute = false;
        }
        else if (PlayerPrefs.GetInt("AudioOFF") == 1)
        {
            GetComponent<AudioSource>().mute = true;
        }
    }

    // Выбор случайного трека из массива при старте приложения
    void InitializeBackgroundMusic()
    {
        currentMusic = Random.Range(0, backgroundMusic.Length); //chose a random index for music to be played
    }
}
