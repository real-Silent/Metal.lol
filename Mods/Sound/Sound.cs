using GorillaNetworking;
using HarmonyLib;
using Metal.lol.Mods.RPC;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Metal.lol.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class Sound
    {
        public static void KeyboardSpam()
        {
            float idk = 1f;
            if (PhotonNetwork.InRoom)
            {
                if (idk < Time.time)
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlayHandTap", RpcTarget.All, new object[] { 66, false, 999f });
                    rpc.RPCPROTECTION();
                    idk = Time.time + 1f;
                }
            }
            rpc.RPCPROTECTION();
        }

        public static void btnSpam()
        {
            float idk = 1f;
            if (PhotonNetwork.InRoom)
            {
                if (idk < Time.time)
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlayHandTap", RpcTarget.All, new object[] { 67, false, 999f });
                    rpc.RPCPROTECTION();
                    idk = Time.time + 1f;
                }
            }
            rpc.RPCPROTECTION();
        }

        public static void metalSpam()
        {
            float idk = 1f;
            if (PhotonNetwork.InRoom)
            {
                if (idk < Time.time)
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlayHandTap", RpcTarget.All, new object[] { 45, false, 999f });
                    rpc.RPCPROTECTION();
                    idk = Time.time + 1f;
                }
            }
            rpc.RPCPROTECTION();
        }

        public static void glassSpam()
        {
            float idk = 1f;
            if (PhotonNetwork.InRoom)
            {
                if (idk < Time.time)
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlayHandTap", RpcTarget.All, new object[] {29, false, 999f });
                    rpc.RPCPROTECTION();
                    idk = Time.time + 1f;
                }
            }
            rpc.RPCPROTECTION();
        }

        public static void BarkSpam()
        {
            float idk = 1f;
            if (PhotonNetwork.InRoom)
            {
                if (idk < Time.time)
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlayHandTap", RpcTarget.All, new object[] {2, false, 999f});
                    rpc.RPCPROTECTION();
                    idk = Time.time + 1f;
                }
            }
            rpc.RPCPROTECTION();
        }


        /*public static void PlayEyeMonsterMoonEvent() 
        {
            MoonController controller = GameObject.FindFirstObjectByType<MoonController>();
            Transform openMoon = Traverse.Create(controller).Field("openMoon").GetValue<Transform>();
            Transform closedMoon = Traverse.Create(controller).Field("defaultMoon").GetValue<Transform>();
            controller.gameObject.SetActive(true);
        }*/
    }
}
