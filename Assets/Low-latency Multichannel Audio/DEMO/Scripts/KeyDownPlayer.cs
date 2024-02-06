using UnityEngine;
using UnityEngine.UI;
using ASIO.NET;

namespace LowLatencyMultichannelAudio.DEMO
{
    public class KeyDownPlayer : MonoBehaviour
    {
        [SerializeField]
        private Text Text_TimeLength;

        [SerializeField]
        private Slider Slider_TimePosition;
        private bool IsScriptChange_TimePosition;

        private SoundStream SoundStream;
        private float Volume = 1;

        public void OnVolumeChanged(float value)
        {
            Volume = value;

            /* B'. change volume */
            SoundStream?.SetVolume(value);
        }

        public void OnSpeedChanged(float value)
        {
            /* B'. change speed */
            SoundStream?.SetSpeed(value);
        }

        public void OnPositionChanged(float time)
        {
            if (IsScriptChange_TimePosition)
            {
                IsScriptChange_TimePosition = false;
                return;
            }

            /* B'. change position */
            SoundStream?.SetCurrentTime(time);
        }

        private void UpdateTimeInfo()
        {
            if (SoundStream == null)
                return;

            /* B'. getting current time */
            IsScriptChange_TimePosition = true;
            Slider_TimePosition.value = SoundStream.GetCurrentTime();
        }

        void Update()
        {
            /* A. play one shot */
            if (Input.GetKeyDown(KeyCode.Alpha1))
                AudioManager.Asio.Play(
                    soundID: 1,
                    outChannels: new uint[] { 0 });

            if (Input.GetKeyDown(KeyCode.Alpha2))
                AudioManager.Asio.Play(
                    soundID: 2,
                    outChannels: new uint[] { 1 });

            if (Input.GetKeyDown(KeyCode.Alpha3))
                AudioManager.Asio.Play(
                    soundID: 3,
                    outChannels: new uint[] { 2 });

            if (Input.GetKeyDown(KeyCode.Alpha4))
                AudioManager.Asio.Play(
                    soundID: 1,
                    outChannels: new uint[] { 3 });

            if (Input.GetKeyDown(KeyCode.Alpha5))
                AudioManager.Asio.Play(
                    soundID: 2,
                    outChannels: new uint[] { 4 });
        
            if (Input.GetKeyDown(KeyCode.Alpha6))
                AudioManager.Asio.Play(
                    soundID: 2,
                    outChannels: new uint[] { 5 });

            if (Input.GetKeyDown(KeyCode.Alpha7))
                AudioManager.Asio.Play(
                    soundID: 2,
                    outChannels: new uint[] { 6 });

            if (Input.GetKeyDown(KeyCode.Alpha8))
                AudioManager.Asio.Play(
                    soundID: 2,
                    outChannels: new uint[] { 7 });

            /* B. play looping, 1s fade */
            /* if (Input.GetKeyDown(KeyCode.Alpha4))
             {
                 SoundStream?.Stop(fadeSec: 0);

                 SoundStream = AudioManager.Asio.Play(
                     soundID: 4,
                     outChannels: new uint[] { 0, 1 },
                     volume: Volume,
                     fadeSec: 1.0f,
                     looping: true);

                 // getting total time position
                 var totalTime = SoundStream.GetTotalTime();
                 Text_TimeLength.text = totalTime.ToString("F2");
                 Slider_TimePosition.maxValue = totalTime;
             }
             UpdateTimeInfo();

             if (Input.GetKeyDown(KeyCode.Alpha5))
                 SoundStream.Pause(fadeSec: 0);

             if (Input.GetKeyDown(KeyCode.Alpha6))
                 SoundStream.Resume(fadeSec: 0);

             if (Input.GetKeyDown(KeyCode.Alpha7))
                 SoundStream.Stop(fadeSec: 1.0f);

             /* C. stop all */
            if (Input.GetKeyDown(KeyCode.Space))
                AudioManager.Asio.StopAll();
        }
    }
}
