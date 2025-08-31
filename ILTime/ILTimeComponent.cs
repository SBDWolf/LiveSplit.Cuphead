using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.Cuphead.ExtraComponents
{
    public class ILTimeComponent : IComponent
    {
        public string ComponentName => "Cuphead IL Time Display";
        public float HorizontalWidth => textInfo.HorizontalWidth;
        public float MinimumHeight => textInfo.MinimumHeight;
        public float VerticalHeight => textInfo.VerticalHeight;
        public float MinimumWidth => textInfo.MinimumWidth;
        public float PaddingTop => textInfo.PaddingTop;
        public float PaddingBottom => textInfo.PaddingBottom;
        public float PaddingLeft => textInfo.PaddingLeft;
        public float PaddingRight => textInfo.PaddingRight;

        public IDictionary<string, Action> ContextMenuControls => null;


        private InfoTextComponent textInfo;
        private MemoryManager memory;

        public ILTimeComponent(MemoryManager memory)
        {
            textInfo = new InfoTextComponent("IGT: 7", "");
            textInfo.LongestString = "IGT: 999.99";
            this.memory = memory;
        }

        public void Dispose()
        {
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            if (state.LayoutSettings.BackgroundColor.ToArgb() != Color.Transparent.ToArgb())
            {
                g.FillRectangle(new SolidBrush(state.LayoutSettings.BackgroundColor), 0, 0, HorizontalWidth, height);
            }
            PrepareDraw(state, LayoutMode.Horizontal);
            textInfo.DrawHorizontal(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            if (state.LayoutSettings.BackgroundColor.ToArgb() != Color.Transparent.ToArgb())
            {
                g.FillRectangle(new SolidBrush(state.LayoutSettings.BackgroundColor), 0, 0, width, VerticalHeight);
            }
            PrepareDraw(state, LayoutMode.Vertical);
            textInfo.DrawVertical(g, state, width, clipRegion);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return document.CreateElement("Settings");
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            return null;
        }

        public void SetSettings(XmlNode settings)
        {
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (!memory.LevelWon())
            {
                textInfo.InformationName = "IGT: " + memory.LevelTime().ToString("0.00") + "s";
                textInfo.Update(invalidator, state, width, height, mode);
            }
            else
            {
                textInfo.InformationName = "IGT: " + memory.ScoringTime().ToString("0.00") + "s";
                textInfo.Update(invalidator, state, width, height, mode);
            }

            if (invalidator != null)
            {
                invalidator.Invalidate(0, 0, width, height);
            }
        }


        private void PrepareDraw(LiveSplitState state, LayoutMode mode)
        {
            textInfo.DisplayTwoRows = false;
            textInfo.NameLabel.HasShadow = textInfo.ValueLabel.HasShadow = state.LayoutSettings.DropShadows;
            textInfo.NameLabel.HorizontalAlignment = StringAlignment.Near;
            textInfo.ValueLabel.HorizontalAlignment = StringAlignment.Near;
            textInfo.NameLabel.VerticalAlignment = StringAlignment.Near;
            textInfo.ValueLabel.VerticalAlignment = StringAlignment.Near;
            textInfo.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            textInfo.ValueLabel.ForeColor = state.LayoutSettings.TextColor;
        }
    }
}
