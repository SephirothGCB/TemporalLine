﻿using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;

namespace TemporalLine.Components
{
    /// <summary>
    /// This component is used as the selected area.
    /// </summary>
    public class SelectedTemporalLine : View
	{
        private int mWidth, mHeight;
		private Paint mPaint;

        public Color SelectedColor { get; set; }

		public SelectedTemporalLine(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
			this.Init(attrs);
		}

		public SelectedTemporalLine(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
			this.Init(attrs);
		}

		public SelectedTemporalLine(Context context) : base(context)
        {
            this.Init(null);
		}

		public SelectedTemporalLine(Context context, IAttributeSet attrs) : base(context, attrs)
        {
			this.Init(attrs);
		}

		protected override void OnDraw(Canvas canvas)
		{
			this.mPaint = new Paint();

			this.mPaint.StrokeWidth = 0;
            this.mPaint.Color = this.SelectedColor;
            //canvas.DrawRect(3, 3, this.mWidth - 3, this.mHeight - 3, this.mPaint);
            canvas.DrawRect(0, 0, this.mWidth, this.mHeight, this.mPaint);
        }

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
            TemporalLineHelper.MeasureView(widthMeasureSpec, heightMeasureSpec, out this.mWidth, out this.mHeight);
			this.SetMeasuredDimension(this.mWidth, this.mHeight);
		}

        private void Init(IAttributeSet attrs)
		{
        }
    }
}
