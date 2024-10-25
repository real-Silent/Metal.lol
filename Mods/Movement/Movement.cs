using BepInEx;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Metal.lol.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */

    // I KNOW THE CODES MESSY ALL RIGHT - Silent
    internal class Movement
    {
        #region plats
        public static GameObject plat1;
        public static GameObject plat2;
        public static void Platforms()
        {
            if (plat1 == null)
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    plat1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat1.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                    plat1.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation * Quaternion.Euler(0, 0, 90);
                    plat1.GetComponent<Renderer>().material.color = Color.cyan;
                    plat1.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                }
            }
            if (plat1 != null)
            {
                if (!ControllerInputPoller.instance.rightGrab)
                {
                    GameObject.Destroy(plat1, Time.deltaTime);
                }
            }

            if (plat2 == null)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    plat2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat2.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                    plat2.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation * Quaternion.Euler(0, 0, 90);
                    plat2.GetComponent<Renderer>().material.color = Color.cyan;
                    plat2.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                }
            }
            if (plat2 != null)
            {
                if (!ControllerInputPoller.instance.leftGrab)
                {
                    GameObject.Destroy(plat2, Time.deltaTime);
                }
            }
        }
        #endregion

        #region plats
        public static void InvisPlatforms()
        {
            if (plat1 == null)
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    plat1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat1.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                    plat1.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation * Quaternion.Euler(0, 0, 90);
                    plat1.GetComponent<Renderer>().enabled = false;
                    plat1.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                }
            }
            if (plat1 != null)
            {
                if (!ControllerInputPoller.instance.rightGrab)
                {
                    GameObject.Destroy(plat1, Time.deltaTime);
                }
            }

            if (plat2 == null)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    plat2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat2.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                    plat2.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation * Quaternion.Euler(0, 0, 90);
                    plat2.GetComponent<Renderer>().enabled = false;
                    plat2.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                }
            }
            if (plat2 != null)
            {
                if (!ControllerInputPoller.instance.leftGrab)
                {
                    GameObject.Destroy(plat2, Time.deltaTime);
                }
            }
        }
        #endregion

        #region Stickyplats
        public static GameObject plat3;
        public static GameObject plat4;
        public static void StickyPlatforms()
        {
            if (plat4 == null)
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    plat4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    plat4.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                    plat4.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation * Quaternion.Euler(0, 0, 90);
                    plat4.GetComponent<Renderer>().material.color = Color.cyan;
                    plat4.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                    plat4.AddComponent<SphereCollider>().enabled = true;
                }
            }
            if (plat4 != null)
            {
                if (!ControllerInputPoller.instance.rightGrab)
                {
                    GameObject.Destroy(plat4, Time.deltaTime);
                }
            }

            if (plat3 == null)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    plat3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    plat3.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                    plat3.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation * Quaternion.Euler(0, 0, 90);
                    plat3.GetComponent<Renderer>().material.color = Color.cyan;
                    plat3.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                    plat3.AddComponent<SphereCollider>().enabled = true;
                }
            }
            if (plat3 != null)
            {
                if (!ControllerInputPoller.instance.leftGrab)
                {
                    GameObject.Destroy(plat3, Time.deltaTime);
                }
            }
        }
        #endregion

        #region Fly
        public static void Fly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.3f;
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
            }
        }

        public static void BFly()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.3f;
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
            }
        }

        public static void XFly()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.3f;
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
            }
        }

        public static void HFly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward * 0.3f;
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
            }
        }
        #endregion

        #region ExcelFly
        public static void ExcelFly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightControllerTransform.right / 2f;
            }

            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftControllerTransform.right / 2f;
            }
        }

        public static void SpeedBoost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 7.2f;
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 7.6f;
        }

        public static void SSpeedBoost()
        {
            GorillaLocomotion.Player.Instance.jumpMultiplier = 6.7f;
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 6.6f;
        }

        public static void IronMan()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightControllerTransform.right / 2f;
                GorillaTagger.Instance.tagHapticStrength = 1;
            }

            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftControllerTransform.right / 2f;
                GorillaTagger.Instance.tagHapticStrength = 1;
            }
        }
        #endregion

        #region NoTagFreeze
        public static void NoTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = false;
        }

        public static void ForceTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = true;
        }
        #endregion

        #region LongArms
        public static void LongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }

        public static void ExtremeLongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(2.9f, 2.9f, 2.9f);
        }

        public static void SmallArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }


        public static void NoLongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        #endregion


        public static void NCFly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * 0.3f;
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity = Vector3.zero;
                foreach (MeshCollider meshCollider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    meshCollider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider meshCollider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    meshCollider.enabled = true;
                }
            }
        }

        #region NoClip
        public static void NoClip()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
            {
                foreach (MeshCollider meshCollider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    meshCollider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider meshCollider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
                {
                    meshCollider.enabled = true;
                }
            }
        }
        #endregion

        #region Ghost Mods
        public static void GhostMonke()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }

        }


        public static void Invis()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(34344f, 343f, 23492f);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        #endregion

        #region GRabRig
        public static void GrabRig()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        #endregion


        public static void TPGun()
        {
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
                    GorillaLocomotion.Player.Instance.transform.position = gameObject20.transform.position;
                }
            }
        }

        public static void RigGun()
        {
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
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = gameObject20.transform.position;
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
            }
        }
    }
}
