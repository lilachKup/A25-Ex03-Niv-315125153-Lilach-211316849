using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class AlbumCollection
    {
        private const int k_NoPhotos = 0;
        private const bool v_IsForwardIterator = true;
        private const int k_BeforeFirstIndex = -1;
        private const int k_FirstIndex = 0;

        private readonly List<string> r_Photos;

        public AlbumCollection(Album i_Album)
        {
            r_Photos = getAlbumAsList(i_Album);
        }

        public List<string> getAlbumAsList(Album i_Album)
        {
            List<string> photoUrls = new List<string>();

            if (i_Album.Count > k_NoPhotos)
            {
                foreach (Photo photo in i_Album.Photos)
                {
                    if (!string.IsNullOrEmpty(photo.PictureNormalURL))
                    {
                        photoUrls.Add(photo.PictureNormalURL);
                    }
                }
            }
            else
            {
                photoUrls = new List<string>();
            }

            return photoUrls;
        }

        public bool IsEmptyAlbum()
        {
            return r_Photos.Count == k_NoPhotos;
        }

        public IIterator<string> CreateForwardIterator()
        {
            return new AlbumIterator(this, v_IsForwardIterator);
        }

        public IIterator<string> CreateReverseIterator()
        {
            return new AlbumIterator(this, !v_IsForwardIterator);
        }

        private class AlbumIterator : IIterator<string>
        {
            private readonly AlbumCollection r_AlbumCollection;
            private int m_CurrentIndex;

            public AlbumIterator(AlbumCollection i_AlbumCollection, bool i_IsForward)
            {
                r_AlbumCollection = i_AlbumCollection;
                m_CurrentIndex = i_IsForward ? k_BeforeFirstIndex : r_AlbumCollection.r_Photos.Count;
            }

            public bool HasNext()
            {
                return m_CurrentIndex < r_AlbumCollection.r_Photos.Count - 1;
            }

            public string Next()
            {
                if (HasNext())
                {
                    m_CurrentIndex++;
                    return r_AlbumCollection.r_Photos[m_CurrentIndex];
                }
                else
                {
                    throw new InvalidOperationException("Out Of Range");
                }
            }

            public bool HasPrevious()
            {
                return m_CurrentIndex > k_FirstIndex;
            }

            public string Previous()
            {
                if (HasPrevious())
                {
                    m_CurrentIndex--;
                    return r_AlbumCollection.r_Photos[m_CurrentIndex];
                }
                else
                {
                    throw new InvalidOperationException("Out Of Range");
                }
            }
        }
    }
}
