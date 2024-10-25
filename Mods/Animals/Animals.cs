using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Metal.lol.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class Animals
    {
        public static void Grabbug()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject Bug = GameObject.Find("Floating Bug Holdable");
                Bug.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            }
        }

        public static void BugGun()
        {
            GameObject doug = GameObject.Find("Floating Bug Holdable");
            if (ControllerInputPoller.instance.rightGrab)
            {
                #region GunMaker
                GameObject cubeobj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubeobj1.transform.localScale = new Vector3(0.05f, 0.1f, 0.05f);
                cubeobj1.transform.parent = GorillaLocomotion.Player.Instance.rightControllerTransform;
                cubeobj1.transform.localRotation = Quaternion.identity;
                cubeobj1.transform.localPosition = new Vector3(0, 0, 0);
                UnityEngine.Object.Destroy(cubeobj1.GetComponent<Collider>());
                UnityEngine.Object.Destroy(cubeobj1, Time.deltaTime);
                GameObject cubeobj2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubeobj2.transform.localScale = new Vector3(0.05f, 0.1f, 0.05f);
                cubeobj2.transform.parent = GorillaLocomotion.Player.Instance.rightControllerTransform;
                cubeobj2.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                cubeobj2.transform.localPosition = new Vector3(0, 0.025f, 0.075f);
                UnityEngine.Object.Destroy(cubeobj2.GetComponent<Collider>());
                UnityEngine.Object.Destroy(cubeobj2, Time.deltaTime);
                cubeobj1.GetComponent<Renderer>().material.color = Color.black;
                cubeobj2.GetComponent<Renderer>().material.color = Color.grey;
                #endregion
                RaycastHit raycastHit15;
                Physics.Raycast(cubeobj2.transform.position - cubeobj2.transform.up, -cubeobj2.transform.up, out raycastHit15);
                GameObject gameObject20 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gameObject20.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
                gameObject20.transform.position = raycastHit15.point;
                UnityEngine.Object.Destroy(gameObject20.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject20.GetComponent<Collider>());
                UnityEngine.Object.Destroy(gameObject20, Time.deltaTime);
                gameObject20.GetComponent<Renderer>().material.color = Color.grey;
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                {
                    gameObject20.GetComponent<Renderer>().material.color = Color.red;
                    doug.transform.position = gameObject20.transform.position;
                }
            }
        }

        public static void Grabbat()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject Bug = GameObject.Find("Cave Bat Holdable");
                Bug.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            }
        }

        public static void batGun()
        {
            GameObject doug = GameObject.Find("Cave Bat Holdable");
            if (ControllerInputPoller.instance.rightGrab)
            {
                #region GunMaker
                GameObject cubeobj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubeobj1.transform.localScale = new Vector3(0.05f, 0.1f, 0.05f);
                cubeobj1.transform.parent = GorillaLocomotion.Player.Instance.rightControllerTransform;
                cubeobj1.transform.localRotation = Quaternion.identity;
                cubeobj1.transform.localPosition = new Vector3(0, 0, 0);
                UnityEngine.Object.Destroy(cubeobj1.GetComponent<Collider>());
                UnityEngine.Object.Destroy(cubeobj1, Time.deltaTime);
                GameObject cubeobj2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cubeobj2.transform.localScale = new Vector3(0.05f, 0.1f, 0.05f);
                cubeobj2.transform.parent = GorillaLocomotion.Player.Instance.rightControllerTransform;
                cubeobj2.transform.localRotation = Quaternion.Euler(-90, 0, 0);
                cubeobj2.transform.localPosition = new Vector3(0, 0.025f, 0.075f);
                UnityEngine.Object.Destroy(cubeobj2.GetComponent<Collider>());
                UnityEngine.Object.Destroy(cubeobj2, Time.deltaTime);
                cubeobj1.GetComponent<Renderer>().material.color = Color.black;
                cubeobj2.GetComponent<Renderer>().material.color = Color.grey;
                #endregion
                RaycastHit raycastHit15;
                Physics.Raycast(cubeobj2.transform.position - cubeobj2.transform.up, -cubeobj2.transform.up, out raycastHit15);
                GameObject gameObject20 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gameObject20.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
                gameObject20.transform.position = raycastHit15.point;
                UnityEngine.Object.Destroy(gameObject20.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(gameObject20.GetComponent<Collider>());
                UnityEngine.Object.Destroy(gameObject20, Time.deltaTime);
                gameObject20.GetComponent<Renderer>().material.color = Color.grey;
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                {
                    gameObject20.GetComponent<Renderer>().material.color = Color.red;
                    doug.transform.position = gameObject20.transform.position;
                }
            }
        }

        public static void Grabball()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject Bug = GameObject.Find("BeachBall");
                Bug.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            }
        }
    }
}
