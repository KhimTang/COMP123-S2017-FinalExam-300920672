using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Name: Khim Tang
 * StudentID: 300920672
 * Date: August 17. 2017
 * Description: This is the ScoreBoard class
 * Version: 0.1 - added the ScoreBoard class
*/

namespace COMP123_S2017_FinalExam_300920672
{
    public class ScoreBoard
    {
        //PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;
        private int _score;        
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        



        //PUBLIC PROPERTIES
        public TextBox FinalScoreTextBox
        {
            get
            {
               return this._finalScoreTextBox ;
            }
            set
            {
              this._finalScoreTextBox = value ;
            }
        }

        public int Score
        {
            get
            { return this._score;

            }
            set
            {
                this._score=value;
                ScoreTextBox.Text = this._score.ToString();
                

            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox ;
            }
            set
            {
               this._scoreTextBox=value ;
            }
        }
        public int Time
        {
            get
            {
              return this._time  ;
            }
            set
            {
               this._time = value ;
            }
        }
        public TextBox TimeTextBox
        {
            get
            { return this._timeTextBox; }
            set
            {
                this._timeTextBox=value;
            }
        }

        //CONSTRUCTOR
        /// <summary>
        /// this the main constructor for ScoreBoard
        /// it takes 3 parameters
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTexBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTexBox, TextBox finalScoreTextBox)
        {
            this.Score = scoreTextBox;
            this.Time = TimeTextBox.;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
        public void UpdateTime()
        {

        }

    }
}