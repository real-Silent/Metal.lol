using HarmonyLib;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metal.lol.Mods.RPC
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class rpc
    {
        public static PhotonView skibidi(VRRig p)
        {
            return (PhotonView)Traverse.Create(p).Field("photonView").GetValue();
        }


        public static void RPCPROTECTION() // credits asteroid (@asteroidrealaccount on discord)
        {
            PhotonNetwork.MaxResendsBeforeDisconnect = int.MaxValue;
            GorillaNot.instance.rpcCallLimit = int.MaxValue;
            GorillaNot.instance.rpcErrorMax = int.MaxValue;
            GorillaNot.instance.logErrorMax = int.MaxValue;
            PhotonNetwork.CleanRpcBufferIfMine(skibidi(GorillaTagger.Instance.offlineVRRig));
            PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
            PhotonNetwork.OpCleanRpcBuffer(skibidi(GorillaTagger.Instance.offlineVRRig));
            PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
            PhotonNetwork.RemoveBufferedRPCs();
            PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
            PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
            PhotonNetwork.SendAllOutgoingCommands();
            GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
        }
    }
}
