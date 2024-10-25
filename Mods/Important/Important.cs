using GorillaNetworking;
using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Metal.lol.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class Important
    {
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }


        /*
        public static void FirstPersonCam()
        {
            GameObject fpc = GameObject.Find("Third Person Camera");
            fpc.SetActive(true);
        }

        public static void FirstPersonCamOff()
        {
            GameObject fpc = GameObject.Find("Third Person Camera");
            fpc.SetActive(false);
        }*/
        public static void ClearNotis()
        {
            NotifiLib.ClearAllNotifications();
        }

        public static void Fastquit() // this is pretty fast asf
        {
            GameObject quitbox = GameObject.Find("QuitBox");
            GorillaLocomotion.Player.Instance.transform.position = quitbox.transform.position;
            foreach (MeshCollider meshCollider in UnityEngine.Object.FindObjectsOfType<MeshCollider>())
            {
                meshCollider.enabled = false;
            }
        }

        public static void MCheck()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                NotifiLib.SendNotification("[<color=cyan>MENU</color>] YOU ARE MASTER CLIENT");
            }
            if (!PhotonNetwork.IsMasterClient)
            {
                NotifiLib.SendNotification("[<color=cyan>MENU</color>] YOU ARE NOT MASTER CLIENT");
            }
        }

        public static void JoinPublic()
        {

        }
    }
}
