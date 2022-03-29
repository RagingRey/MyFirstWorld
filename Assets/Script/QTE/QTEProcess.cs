using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.QTE
{
    public class QTEProcess : MonoBehaviour
    {
        public Text question;
        public int qteGen;
        public bool waitingForKey = true;
        public bool correctKey = false;
        public Text pass;
        public bool countDown = false;

        void Update()
        {
            if (waitingForKey)
            {
                waitingForKey = false;
                qteGen = Random.Range(1, 4);

                if (qteGen == 1)
                {
                    question.text = "[Q]";
                    countDown = true;
                    StartCoroutine(CountDown());
                }
                else if (qteGen == 2)
                {
                    question.text = "[T]";
                    countDown = true;
                    StartCoroutine(CountDown());
                }
                if (qteGen == 3)
                {
                    question.text = "[E]";
                    countDown = true;
                    StartCoroutine(CountDown());
                }
            }

            if (qteGen == 1)
            {
                if (Input.anyKeyDown)
                {
                    if (Input.GetKey(KeyCode.Q))
                    {
                        correctKey = true;
                        StartCoroutine(KeyPressed());
                    }
                    else
                    {
                        correctKey = false;
                        StartCoroutine(KeyPressed());
                    }
                }
            }

            if (qteGen == 2)
            {
                if (Input.anyKeyDown)
                {
                    if (Input.GetKey(KeyCode.T))
                    {
                        correctKey = true;
                        StartCoroutine(KeyPressed());
                    }
                    else
                    {
                        correctKey = false;
                        StartCoroutine(KeyPressed());
                    }
                }
            }

            if (qteGen == 3)
            {
                if (Input.anyKeyDown)
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        correctKey = true;
                        StartCoroutine(KeyPressed());
                    }
                    else
                    {
                        correctKey = false;
                        StartCoroutine(KeyPressed());
                    }
                }
            }
        }

        IEnumerator KeyPressed()
        {
            if (correctKey)
            {
                countDown = false;
                pass.text = "Correct";
                yield return new WaitForSeconds(1.5f);
                correctKey = false;
                question.text = "";
                pass.text = "";
                yield return new WaitForSeconds(1.5f);
                FirstQTE.i++;
                waitingForKey = true;
            }
            else if(correctKey == false)
            {
                countDown = false;
                pass.text = "Incorrect";
                yield return new WaitForSeconds(1.5f);
                correctKey = false;
                question.text = "";
                pass.text = "";
                yield return new WaitForSeconds(1.5f);
                waitingForKey = true;
            }
        }

        IEnumerator CountDown()
        {
            yield return new WaitForSeconds(3.5f);

            if (countDown)
            {
                countDown = false;
                pass.text = "Failed";
                correctKey = false;
                yield return new WaitForSeconds(1.5f);
                pass.text = "";
                question.text = "";
                yield return new WaitForSeconds(1.5f);
                waitingForKey = true;
            }
        }
    }
}
