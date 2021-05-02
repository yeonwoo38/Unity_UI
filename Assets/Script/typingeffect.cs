using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect : MonoBehaviour
{
    public Text tx;
    private string m_text = "Who Are You";
    bool a;
    public AudioClip typingSound;
    private AudioSource musicPlayer;
    int e;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        a = true;
    }

    void Update()
    {
        if (a == true)
        {
            StartCoroutine(_typing());
            a = false;
        }
        

    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0f);
        for(int i=0;i<=m_text.Length;i++)
        {
            e += 1;
            if (e > 1)
            {
                if (e == m_text.Length)
                {
                    e = 0;
                }
                musicPlayer.Stop();
            }
            else
            {
                musicPlayer.Play();
            }
            tx.text = m_text.Substring(0,i);
           

            yield return new WaitForSeconds(0.15f);

        }
    }
}
