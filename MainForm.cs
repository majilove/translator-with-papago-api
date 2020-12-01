using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;     //Nuget패키지 설치  
using Microsoft.Speech;
using Microsoft.Speech.Synthesis;

namespace Translator
{
    public partial class MainForm : Form
    {
        private string client_id;
        private string client_secret;

        private List<Language> language = new List<Language>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            client_id = "a9giYqm3Q6t1_4xKsB5v";
            client_secret = "EQ19EDLfO5";

            labLength.BringToFront();
            labLength2.BringToFront();

            txtPrev.MaxLength = 5000;
            txtNext.ReadOnly = true;        //읽기 전용

            language.Add(new Language("한국어", "ko", "ko-KR", "Heami"));          //ko-KR
            language.Add(new Language("영어", "en", "en-US", "Helen"));           //en-US
            language.Add(new Language("일본어", "ja", "ja-JP", "Haruka"));          //ja-JP
            language.Add(new Language("중국어 간체", "zh-CN", "zh-CN", "HuiHui"));            //yue-HK
            language.Add(new Language("중국어 번체", "zh-TW", "zh-TW", "HanHan"));            //yue-HK
            language.Add(new Language("스페인어", "es", "es-ES", "Helena"));         //es-ES
            language.Add(new Language("프랑스어", "fr", "fr-CA", "Harmonie"));         //fr-CA
            language.Add(new Language("베트남어", "vi"));         //vi-VN//
            language.Add(new Language("태국어", "th"));          //th-TH//
            language.Add(new Language("인도네시아어", "id"));           //id-ID//
            language.Add(new Language("독일어", "de", "de-DE", "Hedda"));          //de-DE
            language.Add(new Language("이탈리아어", "it", "it-IT", "Helena"));            //	it-IT
            language.Add(new Language("러시아어", "ru", "ru-RU", "Elena"));         //ru-RU

            //목록 가져오기
            foreach (Language lang in language)
            {
                cboLang.Items.Add(lang.langName);
                cboLang2.Items.Add(lang.langName);
            }

            cboLang.SelectedIndex = 0;      //한국어
            cboLang2.SelectedIndex = 1;    //영어

            picSpeaker.Image = Properties.Resources.png_spkrOn;
            picSpeaker.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnTrans_Click(object sender, EventArgs e)     //번역하기
        {
            string query = txtPrev.Text;
            string source = string.Empty;
            string target = string.Empty;

            foreach(Language lang in language)
            {
                if(lang.langName == cboLang.SelectedItem.ToString())
                {
                    source = lang.langCode;
                    break;
                }
            }

            foreach (Language lang in language)
            {
                if (lang.langName == cboLang2.SelectedItem.ToString())
                {
                    target = lang.langCode;
                    break;
                }
            }

            //요청 url
            string url = "https://openapi.naver.com/v1/papago/n2mt";        

            //서버에 요청
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //헤더 추가
            request.Headers.Add("X-Naver-Client-Id", client_id);
            request.Headers.Add("X-Naver-Client-Secret", client_secret);

            //파라미터를 Character Set에 맞게 변경
            byte[] byteDataParams = Encoding.UTF8.GetBytes("source="+ source +"&target=" + target + "&text=" + query);

            //요청 데이터 길이
            request.ContentLength = byteDataParams.Length;

            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();

            //응답 가져오기(출력포맷)
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string return_txt = reader.ReadToEnd();

            stream.Close();
            response.Close();
            reader.Close();

            JObject jobject = JObject.Parse(return_txt);

            txtNext.Text = jobject["message"]["result"]["translatedText"].ToString();        //Json 출력포맷에서 필요한 부분 가져옴
        }

        private void txtPrev_TextChanged(object sender, EventArgs e)        //글자 수 길이
        {
            labLength.Text = txtPrev.Text.Length.ToString();
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLang2.SelectedIndex == cboLang.SelectedIndex)
            {
                MessageBox.Show("원본 언어와 목적 언어가 같습니다.");
                if(cboLang.SelectedIndex - 1 < 0)
                    cboLang.SelectedIndex = cboLang.SelectedIndex + 1;
                else
                    cboLang.SelectedIndex = cboLang.SelectedIndex - 1;
            }
        }

        private void cboLang2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLang2.SelectedIndex == cboLang.SelectedIndex)
            {
                MessageBox.Show("원본 언어와 목적 언어가 같습니다.");
                if (cboLang2.SelectedIndex - 1 < 0)
                    cboLang2.SelectedIndex = cboLang2.SelectedIndex + 1;
                else
                    cboLang2.SelectedIndex = cboLang2.SelectedIndex - 1;
            }

            if (cboLang2.SelectedIndex == 3 || cboLang2.SelectedIndex == 4 || cboLang2.SelectedIndex == 7 || cboLang2.SelectedIndex == 8 || cboLang2.SelectedIndex == 9 || cboLang2.SelectedIndex == 11)
            {
                picSpeaker.Enabled = false;
                picSpeaker.Image = Properties.Resources.png_spkrOff;
            }
            else
            {
                picSpeaker.Enabled = true;
                picSpeaker.Image = Properties.Resources.png_spkrOn;
            }
        }

        private void picSpeaker_Click(object sender, EventArgs e)       //Text To Speech
        {
            int i = 0;
            for (i = 0; i < language.Count; i++)
            {
                if (cboLang2.SelectedItem.ToString() == language[i].langName) break;
            }

            using (SpeechSynthesizer ts = new SpeechSynthesizer())     //인스턴스 선언
            {
                ts.SelectVoice($"Microsoft Server Speech Text to Speech Voice ({language[i].ttsCode}, {language[i].ttsName})");
                //Microsoft Server Speech Text to Speech Voice (de-DE, Hedda)

                ts.SetOutputToDefaultAudioDevice();

                try { ts.Speak(txtNext.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
