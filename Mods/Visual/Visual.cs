using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace Metal.lol.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class Visual
    {
        public static void bugesp()
        {
            GameObject bug = GameObject.Find("Floating Bug Holdable");
            GameObject esp = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esp.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
            esp.transform.position = bug.transform.position;
            GameObject.Destroy(esp, Time.deltaTime);
            esp.GetComponent<Collider>().enabled = false;
            esp.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            esp.GetComponent<Renderer>().material.color = Color.blue;
        }

        public static void batesp()
        {
            GameObject bat = GameObject.Find("Cave Bat Holdable");
            GameObject esp1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esp1.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
            esp1.transform.position = bat.transform.position;
            GameObject.Destroy(esp1, Time.deltaTime);
            esp1.GetComponent<Collider>().enabled = false;
            esp1.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            esp1.GetComponent<Renderer>().material.color = Color.blue;
        }

        public static void ESP()
        {
            foreach (VRRig vRRig in GorillaParent.instance.vrrigs)
            {
                if (vRRig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject ESP = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    GameObject rigs = vRRig.gameObject;
                    ESP.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    ESP.transform.position = rigs.transform.position;
                    GameObject.Destroy(ESP, Time.deltaTime);
                    ESP.GetComponent<Collider>().enabled = false;
                    ESP.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                    ESP.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
        }

        #region Tracers
        public static void Tracers() // credits to who ever made these THIS IS TEMP AS I WILL MAKE MY OWN SOON
        {
            GameObject rightHand = GameObject.Find("RightHand Controller");
            if (PhotonNetwork.CurrentRoom != null)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig != GorillaTagger.Instance.offlineVRRig)
                    {
                        GameObject gameObject2 = new GameObject("Line");
                        LineRenderer lineRenderer = gameObject2.AddComponent<LineRenderer>();
                        lineRenderer.startColor = (lineRenderer.endColor = Color.blue);
                        lineRenderer.startWidth = (lineRenderer.endWidth = 0.01f);
                        lineRenderer.positionCount = 2;
                        lineRenderer.SetPositions(new Vector3[]
                        {
                            rightHand.transform.position,
                            vrrig.headMesh.transform.position
                        });
                        lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                        UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
                    }
                }
            }
        }

        #endregion

        public static void Trees()
        {
            // holder THIS IS MEANT TO REMOVE TREES BUT MY STUPID UNITY EXPLORER NO WORKY
        }
        public static void SnakeChams()
        {
            foreach (VRRig vRRig in GorillaParent.instance.vrrigs)
            {
                if (vRRig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject cham = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    GameObject rigs = vRRig.gameObject;
                    cham.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    cham.transform.position = rigs.transform.position;
                    GameObject.Destroy(cham, 1f);
                    cham.GetComponent<Collider>().enabled = false;
                    cham.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                    cham.GetComponent<Renderer>().material.color = Color.blue;
                }

            }
        }
    }
}

// the shader | Shader.Find("GUI/Text Shader");
// the shader V2 | Shader.Find("GorillaTag/UberShader");
