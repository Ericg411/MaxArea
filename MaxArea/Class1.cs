namespace MaxArea;
public class MaxAreaClass
{
    public int MaxArea(int[] height)
    {

        int maxArea = 0;

        int firstIndex = 0;
        int secondIndex = height.Length - 1;

        while (firstIndex < secondIndex)
        {
            int area = 0;
            if (height[firstIndex] <= height[secondIndex])
            {
                area = height[firstIndex] * (secondIndex - firstIndex);
                firstIndex++;
            }
            else if (height[firstIndex] > height[secondIndex])
            {
                area = height[secondIndex] * (secondIndex - firstIndex);
                secondIndex--;
            }

            if (area > maxArea)
            {
                maxArea = area;
            }
        }

        return maxArea;
    }

}
