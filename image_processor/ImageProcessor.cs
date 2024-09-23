using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;

/// <summary>
/// ImageProcessor class
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Inverse method
    /// </summary>
    /// <param name="filenames">Array of filenames</param>
    /// <returns>void</returns>
    public static void Inverse(string[] filenames)
    {
        List<Thread> threads = new List<Thread> { };
        foreach (var filename in filenames)
        {
            // Creamos un hilo para procesar la imagen
            Thread image = new Thread(() => ProcessImage(filename));
            threads.Add(image);
            image.Start();
        }

        // Esperamos a que todos los hilos terminen
        foreach (var thread in threads)
        {
            thread.Join();
        }
    }

    private static void ProcessImage(string imagename)
    {
        using (Bitmap image = new Bitmap(imagename))
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color currentColor = image.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        currentColor.A,
                        255 - currentColor.R,
                        255 - currentColor.G,
                        255 - currentColor.B
                    );
                    image.SetPixel(x, y, invertedColor);
                }
            }
            image.Save($"{imagename}_inverted.jpg");
        }
    }
}
