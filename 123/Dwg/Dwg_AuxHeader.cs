//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_AuxHeader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_AuxHeader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_AuxHeader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_AuxHeader() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_AuxHeader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_unsigned_char aux_intro {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_aux_intro_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AuxHeader_aux_intro_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public ushort dwg_version {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_dwg_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_dwg_version_get(swigCPtr);
      return ret;
    } 
  }

  public ushort maint_version {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_maint_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_maint_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_saves {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_get(swigCPtr);
      return ret;
    } 
  }

  public uint minus_1 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_minus_1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_minus_1_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_saves_1 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_1_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_saves_2 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_2_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_2_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_get(swigCPtr);
      return ret;
    } 
  }

  public ushort dwg_version_1 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_dwg_version_1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_dwg_version_1_get(swigCPtr);
      return ret;
    } 
  }

  public ushort maint_version_1 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_maint_version_1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_maint_version_1_get(swigCPtr);
      return ret;
    } 
  }

  public ushort dwg_version_2 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_dwg_version_2_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_dwg_version_2_get(swigCPtr);
      return ret;
    } 
  }

  public ushort maint_version_2 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_maint_version_2_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_maint_version_2_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short unknown_rs {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_unknown_rs_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AuxHeader_unknown_rs_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char unknown_rc {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_unknown_rc_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AuxHeader_unknown_rc_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public double TDCREATE {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_TDCREATE_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_AuxHeader_TDCREATE_get(swigCPtr);
      return ret;
    } 
  }

  public double TDUPDATE {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_TDUPDATE_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_AuxHeader_TDUPDATE_get(swigCPtr);
      return ret;
    } 
  }

  public uint HANDSEED {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_HANDSEED_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_HANDSEED_get(swigCPtr);
      return ret;
    } 
  }

  public uint plot_stamp {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_plot_stamp_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_plot_stamp_get(swigCPtr);
      return ret;
    } 
  }

  public ushort zero_1 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_1_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_saves_3 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_3_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_3_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_2 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_2_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_3 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_3_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_3_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_4 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_4_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_4_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_saves_4 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_4_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_num_saves_4_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_5 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_5_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_5_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_6 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_6_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_6_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_7 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_7_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_7_get(swigCPtr);
      return ret;
    } 
  }

  public uint zero_8 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_8_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AuxHeader_zero_8_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short zero_18 {
    set {
      LibreDWGPINVOKE.Dwg_AuxHeader_zero_18_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AuxHeader_zero_18_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public Dwg_AuxHeader() : this(LibreDWGPINVOKE.new_Dwg_AuxHeader(), true) {
  }

}