using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip incorrectSound, correctSound, nextLevelSound, answerSound, scene1Intro, scene2Intro;
    public static AudioClip forest001Q001, forest001Q002, forest001Q003, forest001Q004;
    static AudioSource audioSrc;

    void Start()
    {
        incorrectSound = Resources.Load<AudioClip>("V4/Sounds/incorrectSound2");
        correctSound = Resources.Load<AudioClip>("");
        nextLevelSound = Resources.Load<AudioClip>("V4/Sounds/nextLevel");
        forest001Q001 = Resources.Load<AudioClip>("V4/Sounds/Forest/01/hello");
        forest001Q002 = Resources.Load<AudioClip>("V4/Sounds/Forest/01/welcome_to_my_forest");
        forest001Q003 = Resources.Load<AudioClip>("V4/Sounds/Forest/01/can_you_help_me");
        forest001Q004 = Resources.Load<AudioClip>("V4/Sounds/Forest/01/please_tell_me_the_names_of_the_animals");

        // answers
        // animals
        //  catSound = Resources.Load<AudioClip>("Cat");



        audioSrc = GetComponent<AudioSource>();
    }
    public static void playIncorrectSound()
    {
        audioSrc.PlayOneShot(incorrectSound);
    }
    public static void playCorrectSound()
    {
        audioSrc.PlayOneShot(correctSound);
    }
    public static void playNextLevelSound()
    {
        //   audioSrc.PlayOneShot(nextLevelSound);
    }

    // answers

    // animal names
    public static void playAnswerSound(string answerText)
    {
        answerSound = Resources.Load<AudioClip>("Sounds/" + answerText);

        audioSrc.PlayOneShot(answerSound);
    }

    public static void playScene1Intro()
    {
        scene1Intro = Resources.Load<AudioClip>("Sounds/Scene001Intro");
        audioSrc.PlayOneShot(scene1Intro);
    }

    public static void playScene2Intro()
    {
        scene2Intro = Resources.Load<AudioClip>("Sounds/Scene002Intro");
        audioSrc.PlayOneShot(scene2Intro);
    }

    public static void PlaySound(AudioClip sound)
    {
        audioSrc.PlayOneShot(sound);
    }
}
