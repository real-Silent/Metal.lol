using Photon.Pun;
using StupidTemplate;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Metal.lol.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class CustomBoards
    {
        public static void CustomBoards1()
        {
            string coc = $"Menu owner - silent\nMenu devs - silent, asteroid\nour @'s \nsilent - (@s1lnt) ropex - (@ropexreal) asteroid - (@asteroidrealaccount)\nGit hub page - https://github.com/real-Silent/Metal.lol \ndiscord - discord.gg/545ja9768V \n\n\nwe are not responsible for any bans you get using this menu as you have decided to use the menu\n\n\n";
            string coc2 = $">--Credits--<";
            string motdTop = $"Metal";
            if (!PhotonNetwork.InRoom)
            {
                string motd1 = "Thanks For Using Metal.lol This Is A Fully Und Menus Made By Asteroid Silent And Ropex There Is No Anti Report For Now That Will Change In The Future.\n\n\nRoom Info: Not In A Room\n\n\nIf you are reviewing this menu put the discord in the description\n\nTHIS MENU HAS: " + PluginInfo.ModCount + " Mods";
                GameObject.Find("motdtext").GetComponent<TMP_Text>().text = motd1;
            }
            // lets hope lemming dont break these again
            if (PhotonNetwork.InRoom)
            {
                string RoomCode = PhotonNetwork.CurrentRoom.Name;
                string Master = PhotonNetwork.MasterClient.ToString();
                string count = PhotonNetwork.CurrentRoom.PlayerCount.ToString();
                string motd = "Thanks For Using Metal.lol This Is A Fully Und Menus Made By Asteroid Silent And Ropex There Is No Anti Report For Now That Will Change In The Future.\n\n\nRoom Info: Room Code: " + RoomCode + " Player Count: " + count + " Master Client: " + Master + " IGNORE # AND NUMBERS\n\nIf you are reviewing this menu put the discord in the description\n\nTHIS MENU HAS: " + PluginInfo.ModCount + " Mods";
                GameObject.Find("motdtext").GetComponent<TMP_Text>().text = motd;
            }
            GameObject.Find("motd (1)").GetComponent<TMP_Text>().text = motdTop;
            GameObject.Find("COC Text").GetComponent<TMP_Text>().text = coc;
            GameObject.Find("CodeOfConduct").GetComponent<TMP_Text>().text = coc2;
            GameObject boards = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/forestatlas (combined by EdMeshCombinerSceneProcessor)");
            boards.GetComponent<Renderer>().material = new Material(Shader.Find("GorillaTag/UberShader"));
            boards.GetComponent<Renderer>().material.color = new Color32(0, 0, 255, 255);

        }
    }
}
