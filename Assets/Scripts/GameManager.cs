using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    // เก็บคะแนนของผู้เล่น
    public int score;

    // สร้างตัวแปรแบบ Static เพื่อให้สามารถเข้าถึง GameManager ได้จากที่อื่นในโค้ด
    public static GameManager inst;

    // ตัวแปรอ้างอิงไปที่ UI Text สำหรับแสดงคะแนน
    public Text scoreText;

    // ตัวแปรอ้างอิงไปที่สคริปต์ PlayerMovement เพื่อเพิ่มความเร็วเมื่อได้คะแนน
    public PlayerMovement playerMovement;

    // ฟังก์ชันเพิ่มคะแนน
    public void IncrementScore()
    {
        // เพิ่มค่าคะแนนขึ้นทีละ 1
        score++;

        // อัปเดตค่าแสดงผลคะแนนใน UI
        scoreText.text = "score: " + score;

        // เพิ่มความเร็วของผู้เล่นทุกครั้งที่ได้คะแนน
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    // ฟังก์ชัน Awake ทำงานก่อน Start และใช้กำหนดค่า Singleton
    private void Awake()
    {
        // กำหนดให้ inst เป็นอ็อบเจ็กต์ GameManager ปัจจุบัน เพื่อให้สามารถเรียกใช้งานจากที่อื่นได้
        inst = this;
    }

}
