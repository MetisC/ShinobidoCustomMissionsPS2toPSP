using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Shinobido_Custom_Missions_PS2_to_PSP
{
    public enum EMissionTypes
    {
        TypeAssassination = 0,
        TypeTotalDestruction = 1,
        TypeDuel = 2,
        TypeGuard = 3,
        TypeAssault = 4,
        TypeEscort = 5,
        TypeTransport = 6,
        TypeRobbery = 7,
        TypeTheft = 8,
        TypeKidnapping = 9,
        TypeRescue = 10,
        TypeCollection = 11,
        TypeTravel = 12
}
    public class Mission
    {

        public int MissionOrder { get; set; }

        public string MissionPath { get; set; }

        public string MissionType { get; set; }

        public string MissionTitle { get; set; }

        public string MissionDescription { get; set; }

        public Image MissionIcon { get; set; }

        public List<Mission> LoadPSPMissions()
        {
            string nameSave = "UCES00421MissionSave";

            string pathPSP = Properties.Settings.Default.PSPMSPath;

            IEnumerable<string> saveList = Directory.GetDirectories(pathPSP).Where(s => s.Contains(nameSave));

            List<Mission> missionList = new List<Mission>();

            foreach (string save in saveList)
            {
                if (Path.GetFileName(save).Length == nameSave.Length + 2)
                {
                    int order = int.Parse(save.Substring(save.Length - 2, 2));

                    Mission mission = new Mission();

                    mission.MissionOrder = order;
                    mission.MissionPath = save;
                    mission.MissionTitle = ReadHexValue(save + "\\" + "HOMURA.BIN", 0xB0, 0x40);
                    mission.MissionType = ReadHexValue(save + "\\" + "HOMURA.BIN", 0x25, 0x01, true);
                    mission.MissionIcon = Image.FromFile(save + "\\" + "ICON0.PNG");
                    mission.MissionDescription = ReadHexValue(save + "\\" + "HOMURA.BIN", 0x150, 0x190);

                    missionList.Add(mission);

                }
            }

            return missionList;

        }

        public List<Mission> LoadPS2Missions()
        {
            string nameSave = "BESCES-53931CT";

            string pathPS2 = Properties.Settings.Default.PS2MCPath;

            IEnumerable<string> saveList = Directory.GetDirectories(pathPS2).Where(s => s.Contains(nameSave));

            List<Mission> missionList = new List<Mission>();

            foreach (string save in saveList)
            {
                if (Path.GetFileName(save).Length == nameSave.Length + 3)
                {
                    int order = int.Parse(save.Substring(save.Length - 3, 3));

                    string fullPath = Path.GetFullPath(save).TrimEnd(Path.DirectorySeparatorChar);
                    string saveFile = Path.GetFileName(fullPath);

                    Mission mission = new Mission();

                    mission.MissionOrder = order;
                    mission.MissionPath = save;
                    mission.MissionTitle = ReadHexValue(save + "\\" + saveFile, 0xB0, 0x40);
                    mission.MissionType = ReadHexValue(save + "\\" + saveFile, 0x25, 0x01, true);
                    mission.MissionDescription = ReadHexValue(save + "\\" + saveFile, 0x150, 0x190);

                    missionList.Add(mission);

                }
            }

            return missionList;

        }

        public string ReadHexValue (string PathFile, Int16 StartPosition, Int16 Size, bool ReadInt = false)
        {
            BinaryReader reader = new BinaryReader(new FileStream(PathFile, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = StartPosition;

            string text = "";

            try 
            {
                if (ReadInt)
                {
                    int intData = reader.Read();

                    switch ((EMissionTypes)intData)
                    {
                        case EMissionTypes.TypeAssassination:
                            {
                                text = Properties.Settings.Default.TypeAssassination;
                                break;
                            }
                        case EMissionTypes.TypeAssault:
                            {
                                text = Properties.Settings.Default.TypeAssault;
                                break;
                            }
                        case EMissionTypes.TypeCollection:
                            {
                                text = Properties.Settings.Default.TypeCollection;
                                break;
                            }
                        case EMissionTypes.TypeDuel:
                            {
                                text = Properties.Settings.Default.TypeDuel;
                                break;
                            }
                        case EMissionTypes.TypeEscort:
                            {
                                text = Properties.Settings.Default.TypeEscort;
                                break;
                            }
                        case EMissionTypes.TypeGuard:
                            {
                                text = Properties.Settings.Default.TypeGuard;
                                break;
                            }
                        case EMissionTypes.TypeKidnapping:
                            {
                                text = Properties.Settings.Default.TypeKidnapping;
                                break;
                            }
                        case EMissionTypes.TypeRescue:
                            {
                                text = Properties.Settings.Default.TypeRescue;
                                break;
                            }
                        case EMissionTypes.TypeRobbery:
                            {
                                text = Properties.Settings.Default.TypeRobbery;
                                break;
                            }
                        case EMissionTypes.TypeTheft:
                            {
                                text = Properties.Settings.Default.TypeTheft;
                                break;
                            }
                        case EMissionTypes.TypeTotalDestruction:
                            {
                                text = Properties.Settings.Default.TypeTotalDestruction;
                                break;
                            }
                        case EMissionTypes.TypeTransport:
                            {
                                text = Properties.Settings.Default.TypeTransport;
                                break;
                            }
                        case EMissionTypes.TypeTravel:
                            {
                                text = Properties.Settings.Default.TypeTravel;
                                break;
                            }
                    }

                    reader.Close();

                }
                else
                {
                    byte[] data = reader.ReadBytes(Size);
                    reader.Close();

                    foreach (char letter in data)
                    {
                        int value = Convert.ToInt32(letter);
                        if (value != 0) text += Char.ConvertFromUtf32(letter);
                    }

                }
            } 
            catch
            {
            }
            reader.Dispose();

            return text;

        }


    }
}
