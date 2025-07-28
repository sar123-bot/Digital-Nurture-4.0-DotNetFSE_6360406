import styles from './components/CohortDetails.module.css';

function CohortDetails(props) {
    const { cohort } = props;
    const statusColor = cohort.currentStatus.toLowerCase().trim() === 'ongoing' ? 'green' : 'blue';
    return (
        <div className={styles.box}>
            <h3 style={{ color: statusColor }}>
                {props.cohort.cohortCode} -
                <span>{props.cohort.technology}</span>
            </h3>
            <dl>
                <dt>Started On</dt>
                <dd>{props.cohort.startDate}</dd>
                <dt>Current Status</dt>
                <dd>{props.cohort.currentStatus}</dd>
                <dt>Coach</dt>
                <dd>{props.cohort.coachName}</dd>
                <dt>Trainer</dt>
                <dd>{props.cohort.trainerName}</dd>
            </dl>
        </div>

        
    );
}
export default CohortDetails;