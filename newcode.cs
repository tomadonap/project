public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        NavMeshAgent trackBinding = playerData as NavMeshAgent;

        if (!trackBinding)
            return;

        int inputCount = playable.GetInputCount();

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<NavMeshAgentControlBehaviour> inputPlayable = (ScriptPlayable<NavMeshAgentControlBehaviour>)playable.GetInput(i);
            NavMeshAgentControlBehaviour input = inputPlayable.GetBehaviour();

    
	[TrackColor(0.855f, 0.8623f, 0.87f)]
	[TrackClipType(typeof(NavMeshAgentControlClip))]
	[TrackBindingType(typeof(NavMeshAgent))]
	public class NavMeshAgentControlTrack : TrackAsset
	{
	    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	    {
	        return ScriptPlayable<NavMeshAgentControlMixerBehaviour>.Create (graph, inputCount);
	    }
	}
}
