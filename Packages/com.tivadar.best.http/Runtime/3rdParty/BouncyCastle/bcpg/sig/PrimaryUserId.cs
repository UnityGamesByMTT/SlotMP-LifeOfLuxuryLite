#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;

namespace Best.HTTP.SecureProtocol.Org.BouncyCastle.Bcpg.Sig
{
    /**
    * packet giving whether or not the signature is signed using the primary user ID for the key.
    */
    public class PrimaryUserId
        : SignatureSubpacket
    {
        private static byte[] BooleanToByteArray(bool val)
        {
            return new byte[1]{ Convert.ToByte(val) };
        }

        public PrimaryUserId(
            bool    critical,
            bool    isLongLength,
            byte[]  data)
            : base(SignatureSubpacketTag.PrimaryUserId, critical, isLongLength, data)
        {
        }

        public PrimaryUserId(
            bool    critical,
            bool    isPrimaryUserId)
            : base(SignatureSubpacketTag.PrimaryUserId, critical, false, BooleanToByteArray(isPrimaryUserId))
        {
        }

        public bool IsPrimaryUserId()
        {
            return data[0] != 0;
        }
    }
}
#pragma warning restore
#endif
