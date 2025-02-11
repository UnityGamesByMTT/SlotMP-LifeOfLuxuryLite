#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;
using Best.HTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace Best.HTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{

	/// <summary>
	/// Parameters for tweakable block ciphers.
	/// </summary>
	public class TweakableBlockCipherParameters
		: ICipherParameters
	{
		private readonly byte[] tweak;
		private readonly KeyParameter key;

		public TweakableBlockCipherParameters(KeyParameter key, byte[] tweak)
		{
			this.key = key;
			this.tweak = Arrays.Clone(tweak);
		}

		/// <summary>
		/// Gets the key.
		/// </summary>
		/// <value>the key to use, or <code>null</code> to use the current key.</value>
		public KeyParameter Key
		{
			get { return key; }
		}

		/// <summary>
		/// Gets the tweak value.
		/// </summary>
		/// <value>The tweak to use, or <code>null</code> to use the current tweak.</value>
		public byte[] Tweak
		{
			get { return tweak; }
		}
	}
}
#pragma warning restore
#endif
