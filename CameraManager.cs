using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance { get; private set; }

    public string CurrentPositionName { get; private set; }

    public GameObject ButtonLeft;
    public GameObject ButtonRight;
    public GameObject ButtonBack;

    private class CameraPositionInfo
    {
        public Vector3 Position { get; set; }
        public Vector3 Rotate { get; set; }
        public MoveNames MoveNames { get; set; }
    }

    private class MoveNames
    {
        public string Left { get; set; }
        public string Right { get; set; }
        public string Back { get; set; }
    }

    private Dictionary<string, CameraPositionInfo> _CameraPositionInfoes = new Dictionary<string, CameraPositionInfo>

    {
        {
            "Room1_Start",
            new CameraPositionInfo
            {
                Position = new Vector3(1.82f,2.9f,-4.49f),
                Rotate = new Vector3(0,90,0),
                MoveNames = new MoveNames
                {
                    Left = "Room1_Left",
                    Right = "Room1_Right",
                }
            }

        },
        {
            "Room1_Left",
            new CameraPositionInfo
            {
                Position = new Vector3(1.82f,2.9f,-4.49f),
                Rotate = new Vector3(0,-60,0),
                MoveNames = new MoveNames
                {
                    Right = "Room1_Start",
                    Left = "Room1_Right"
                }
            }
        },
        {
            "Room1_Right",
            new CameraPositionInfo
            {
                Position = new Vector3(3.033883f,2.228718f,-4.327303f),
                Rotate = new Vector3(6.646f,213.099f,0),
                MoveNames = new MoveNames
                {
                    Left = "Room1_Start",
                    Right = "Room1_Left",
                }
            }
        },
        {
            "Room1_Bed",
            new CameraPositionInfo
            {
                Position = new Vector3(4.8f,3.5f,-4.29f),
                Rotate = new Vector3(59,87,0),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Start",
                }
            }
        },
        {
            "Room1_Closet",
            new CameraPositionInfo
            {
                Position = new Vector3(6.358891f,2.206599f,-3.23751f),
                Rotate = new Vector3(0,0,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Start",
                }
            }
        },
        {
            "Room1_ClosetOpen",
            new CameraPositionInfo
            {
                Position = new Vector3(6.358891f,2.206599f,-3.23751f),
                Rotate = new Vector3(0,0,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Closet",
                }
            }
        },
        {
            "Room1_Laptop",
            new CameraPositionInfo
            {
                Position = new Vector3(2.306387f,1.914964f,-7.185365f),
                Rotate = new Vector3(26.058f,163.795f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Right",
                }
            }
        },
        {
            "Room1_Shelving",
            new CameraPositionInfo
            {
                Position = new Vector3(6.504467f,1.5f,-6.66f),
                Rotate = new Vector3(31f,101.5f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Start",
                }
            }
        },
        {
            "Room1_Door",
            new CameraPositionInfo
            {
                Position = new Vector3(0.2856142f,2.156722f,-2.475533f),
                Rotate = new Vector3(5.5f,271.082f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Left",
                }
            }
        },
        {
            "Room1_DoorOpen",
            new CameraPositionInfo
            {
                Position = new Vector3(0.2856142f,2.156722f,-2.475533f),
                Rotate = new Vector3(5.5f,271.082f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_Door",
                }
            }
        },
        {
            "Hallway_Start",
            new CameraPositionInfo
            {
                Position = new Vector3(-1.013454f,2.998796f,-2.563615f),
                Rotate = new Vector3(20.741f,270.916f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room1_DoorOpen",
                    Right = "Room2_Start",
                    Left = "Hallway_Left"
                }
            }
        },
        {
            "Hallway_Left",
            new CameraPositionInfo
            {
                Position = new Vector3(-2.909714f,2.380565f,-2.479656f),
                Rotate = new Vector3(2.579f,179.83f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Hallway_Start",
                }
            }
        },
        {
            "Hallway_Goal",
            new CameraPositionInfo
            {
                Position = new Vector3(-5.247851f,2.00363f,-2.460722f),
                Rotate = new Vector3(0.504f,270.275f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Hallway_Start",
                }
            }
        },
        {
            "Room2_Start",
            new CameraPositionInfo
            {
                Position = new Vector3(-2.81f,2.22f,-0.66f),
                Rotate = new Vector3(13.636f,361.03f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Hallway_Start",
                    Left = "Room2_Fridge",
                    Right = "Room2_Right"
                }
            }
        },
        {
            "Room2_Fridge",
            new CameraPositionInfo
            {
                Position = new Vector3(-4.171818f,1.661006f,-0.02504883f),
                Rotate = new Vector3(3.438f,269.794f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Start",
                }
            }
        },
        {
            "Room2_Right",
            new CameraPositionInfo
            {
                Position = new Vector3(-0.4674567f,2.449314f,1.495257f),
                Rotate = new Vector3(18.678f,430.561f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Start",
                }
            }
        },
        {
            "Room2_Table",
            new CameraPositionInfo
            {
                Position = new Vector3(-2.393997f,3.211203f,2.600814f),
                Rotate = new Vector3(54.763f,359.141f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Start",
                }
            }
        },
        {
            "Room2_TableClear",
            new CameraPositionInfo
            {
                Position = new Vector3(-2.393997f,3.211203f,2.600814f),
                Rotate = new Vector3(54.763f,359.141f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Right",
                }
            }
        },
        {
            "Room2_Kitchen",
            new CameraPositionInfo
            {
                Position = new Vector3(-4.137468f,2.608408f,4.140132f),
                Rotate = new Vector3(18.839f,269.072f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Start",
                }
            }
        },
        {
            "Room2_Sofa",
            new CameraPositionInfo
            {
                Position = new Vector3(4.156497f,2.989474f,1.838731f),
                Rotate = new Vector3(31.455f,180.895f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Right",
                }
            }
        },
        {
            "Room2_SofaClear",
            new CameraPositionInfo
            {
                Position = new Vector3(4.156497f,2.989474f,1.838731f),
                Rotate = new Vector3(31.455f,180.895f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Right",
                }
            }
        },
        {
            "Room2_TV",
            new CameraPositionInfo
            {
                Position = new Vector3(4.113434f,1.811002f,3.823427f),
                Rotate = new Vector3(7.723f,358.947f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Right",
                }
            }
        },
        {
            "Room2_Box",
            new CameraPositionInfo
            {
                Position = new Vector3(3.239212f,1.738672f,2.829621f),
                Rotate = new Vector3(38.434f,77.808f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Room2_Right",
                }
            }
        },
        {
            "Room3_Start",
            new CameraPositionInfo
            {
                Position = new Vector3(-3.199325f,2.215597f,-5.892384f),
                Rotate = new Vector3(11.001f,180.072f,0f),
                MoveNames = new MoveNames
                {
                    Back = "Hallway_Left",
                }
            }
        },
    };

    void Start()
    {
        Instance = this;

        ChangeCameraPosition("Room1_Start");

        ButtonBack.GetComponent<Button>().onClick.AddListener(() =>
        {
            ChangeCameraPosition(_CameraPositionInfoes[CurrentPositionName].MoveNames.Back);
        });
        ButtonLeft.GetComponent<Button>().onClick.AddListener(() =>
        {
            ChangeCameraPosition(_CameraPositionInfoes[CurrentPositionName].MoveNames.Left);
        });
        ButtonRight.GetComponent<Button>().onClick.AddListener(() =>
        {
            ChangeCameraPosition(_CameraPositionInfoes[CurrentPositionName].MoveNames.Right);
        });
    }

    public void ChangeCameraPosition(string positionName)
    {
        if (positionName == null) return;

        CurrentPositionName = positionName;

        GetComponent<Camera>().transform.position = _CameraPositionInfoes[CurrentPositionName].Position;
        GetComponent<Camera>().transform.rotation = Quaternion.Euler (_CameraPositionInfoes[CurrentPositionName].Rotate);

        UpdateButtonActive();
    }

    void Update()
    {
        
    }

    private void UpdateButtonActive()
    {
        if (_CameraPositionInfoes[CurrentPositionName].MoveNames.Back == null)
            ButtonBack.SetActive(false);
        else ButtonBack.SetActive(true);
        if (_CameraPositionInfoes[CurrentPositionName].MoveNames.Left == null)
            ButtonLeft.SetActive(false);
        else ButtonLeft.SetActive(true);
        if (_CameraPositionInfoes[CurrentPositionName].MoveNames.Right == null)
            ButtonRight.SetActive(false);
        else ButtonRight.SetActive(true);
    }
}
