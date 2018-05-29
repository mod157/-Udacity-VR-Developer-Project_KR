using UnityEngine;

public class Door : MonoBehaviour
{
    public bool locked;
    public bool opening;

    public Animator ani;
    public AudioClip[] audios;
    public AudioSource audioSource;

    public void OnDoorClicked() {
        if (!opening && !locked)
        {
            //open
            ani.SetTrigger("Open");
            audioSource.clip = audios[0];
            audioSource.Play();
        }
        if (opening && !locked)
        {
            //Close
            ani.SetTrigger("Close");
            audioSource.clip = audios[1];
            audioSource.Play();
        }

        if (locked)
        {
            audioSource.clip = audios[1];
            audioSource.Play();
        }
        
    }

    public void Unlock()
    {
        if(locked)
        {
            locked = false;
        }
    }
}
